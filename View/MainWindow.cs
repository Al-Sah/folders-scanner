using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace FolderScanner.View
{
    public partial class MainWindow : Form
    {
        private const string Root = @"C:\Users\";
        private const string SharedElementsCaption = "Other elements";
        private const bool FindAllUsers = false;
        private const string CollectingData = "Wait )";
        private const string NoInfoStr = "- - - - -"; 

        private readonly List<User> _users;
        public int UsersCount { get; }
        private string _lastSelection = string.Empty;

        public long SharedSpaceUsage { get; private set; }
        private readonly ConfigurationDialog _configurationDialog;
        private readonly ReportDialog _reportDialog;

        private string _currentRoot = string.Empty;
        private ExtendedDirectoryInfo _parentDir = new(Root);
        private List<FileInfo> _files = new();
        private List<ExtendedDirectoryInfo> _dirs = new();

        public Utils.MemoryUnit MemoryUnit { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            MemoryUnit = Utils.MemoryUnit.Bytes;
            _configurationDialog = new ConfigurationDialog {Owner = this};
            _configurationDialog.ApplyNewUnit += item =>
            {
                MemoryUnit = item;
                UpdateSizeLabel();
                ItemsDataGridView.Columns[3].HeaderText = $"Size {MemoryUnit.ToString()}";
                ResetDataGrid();
            };

            _users = GetUsers();
            UsersCount = _users.Count;
            _reportDialog = new ReportDialog(_users.FindAll(user => !user.Disabled && !user.Lockout).ToList())
                {Owner = this};
            
            _reportDialog.Ready += () => BriefReportBtn.Invoke((MethodInvoker) delegate { BriefReportBtn.Enabled = true; });
            _reportDialog.Setup();

            SharedSpaceUsage = -1;
            ThreadPool.QueueUserWorkItem( _ => SharedSpaceUsage = CalculateSharedItemsSpaceUsage());
            FillItemsList();
        }

        private void FillItemsList()
        {
            if (_users.Count == 0)
            {
                MessageBox.Show("No users found", "Unexpected situation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var user in _users)
                {
                    ItemsList.Items.Add(user.Caption);
                }
            }
            ItemsList.Items.Add(SharedElementsCaption);
        }

        private List<User> GetUsers()
        {
            // Get All users using WMI
            var allUsers = new ManagementObjectSearcher(@"SELECT * FROM Win32_UserAccount").Get();
            
            var filteredUsers = allUsers.Cast<ManagementObject>().Where( user =>
            {
                if (FindAllUsers)
                {
                    return (bool) user["LocalAccount"] && int.Parse(user["SIDType"].ToString()) == 1;
                }
                return (bool) user["LocalAccount"] && // Account is defined on the local computer.
                    !(bool)user["Disabled"] &&     // Windows user account is not disabled.
                    !(bool)user["Lockout"]  &&     // User account is not locked out of the Windows operating system.
                    int.Parse(user["SIDType"].ToString()) == 1; // Type is 'SidTypeUser'
            });

            return filteredUsers.Select( user => 
                new User(user, FindUserHomeDir(user["Name"].ToString())))
                .ToList();
        }

        private static string FindUserHomeDir(string user)
        {
            // TODO other locations ??
            return Directory.Exists(Root + user) ? Root + user : string.Empty;
        }

        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = string.Copy(ItemsList.SelectedItem.ToString());
            if (selectedItem == _lastSelection)
            {
                return;
            }
            _lastSelection = selectedItem;
                
            if (selectedItem == SharedElementsCaption)
            {
                ResetRoot(Root);
                SetSharedInformation();
                return;
            }
            var result = _users.Find(user => user.Caption == selectedItem);
            if (result == null) // TODO is it possible ?
            {
                MessageBox.Show($"User {ItemsList.SelectedItem} not found", "Undefined Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ResetRoot(result.HomeDirectory);
            SetUserInformation(result);
        }

        private void UpdateSizeLabel()
        {
            if (SpaceUsedLabelValue.Text is CollectingData or "")
            {
                return;
            }
            if (ItemsList.SelectedItem.ToString() == SharedElementsCaption)
            {
                SpaceUsedLabelValue.Text = $"{Utils.ConvertTo(SharedSpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}";
                return;
            }
            var user = _users.Find(user => user.Caption == ItemsList.SelectedItem.ToString());
            SpaceUsedLabelValue.Text = $"{Utils.ConvertTo(user.SpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}";
        }

        private void BriefReportBtn_Click(object sender, EventArgs e) => _reportDialog.ShowDialog();

        
        private long CalculateSharedItemsSpaceUsage()
        {
            long res = Directory.GetDirectories(Root)
                .Where(dir => !_users.Exists(user => user.HomeDirectory == dir))
                .ToList()
                .Sum(dir => Utils.GetDirectorySize(new DirectoryInfo(dir)));

            res += Directory.GetFiles(Root).Sum(fi => fi.Length);
            return res;
        }
        
        private void SetSharedInformation()
        {
           
            HomeDirectoryLabelValue.Text = Root;
            DisabledLabelValue.Text = NoInfoStr;
            LockoutLabelValue.Text = NoInfoStr;
            NameLabelValue.Text = NoInfoStr;
            CaptionLabelValue.Text = NoInfoStr;
            
            if (SharedSpaceUsage != -1)
            {
                SpaceUsedLabelValue.Text = $"{Utils.ConvertTo(SharedSpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}";
            }
            else
            {
                SpaceUsedLabelValue.Text = CollectingData;
                new Thread(SafeSetSpaceUsedLabelValue){IsBackground = true}.Start();
            }
            
        }
        
        private void SetUserInformation(User user)
        {
            HomeDirectoryLabelValue.Text = user.HomeDirectory;
            DisabledLabelValue.Text = user.Disabled.ToString();
            LockoutLabelValue.Text = user.Lockout.ToString();
            NameLabelValue.Text = user.Name;
            CaptionLabelValue.Text = user.Caption;

            if (user.SpaceUsageValid)
            {
                SpaceUsedLabelValue.Text = user.SpaceUsage == -1 ? NoInfoStr : $"{Utils.ConvertTo(user.SpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}";
            }
            else
            {
                SpaceUsedLabelValue.Text = CollectingData;
                new Thread(() => SafeSetSpaceUsedLabelValue(user)){IsBackground = true}.Start();
            }
        }

        private void SafeSetSpaceUsedLabelValue(User user)
        {
            try
            {
                while (!user.SpaceUsageValid)
                {
                    Thread.Sleep(10);
                }
                var res = user.HomeDirectory != string.Empty ? 
                    $"{Utils.ConvertTo(user.SpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}" : NoInfoStr;
                if (user.Caption == ItemsList.SelectedItem.ToString())
                {
                    SpaceUsedLabelValue.Invoke((MethodInvoker) delegate { SpaceUsedLabelValue.Text = res; });
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        private void SafeSetSpaceUsedLabelValue()
        {
            try
            {
                while (SharedSpaceUsage == -1)
                {
                    Thread.Sleep(10);
                }
                var res = $"{Utils.ConvertTo(SharedSpaceUsage, MemoryUnit):0.00} \nIn {MemoryUnit}";
                if (SharedElementsCaption == ItemsList.SelectedItem.ToString())
                {
                    SpaceUsedLabelValue.Invoke((MethodInvoker) delegate
                    {
                        SpaceUsedLabelValue.Text = res;
                    });
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void ConfigSizeBtn_Click(object sender, EventArgs e) => _configurationDialog.ShowDialog();

        private void ResetRoot(string path)
        {
            _currentRoot = path;
            PathStripLabelValue.Text = _currentRoot;
            _dirs.Clear();
            _files.Clear();
            switch (_currentRoot)
            {
                case "":
                    ItemsDataGridView.Rows.Clear();
                    return;
                case Root:
                    try
                    {
                        _dirs = Directory.GetDirectories(_currentRoot)
                            .Where(dir => !_users.Exists(user => user.HomeDirectory == dir))
                            .Select(dir => new ExtendedDirectoryInfo(dir)).ToList();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Failed to get directories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Debug.WriteLine(e.Message);
                    }
                    break;
                default: // User
                    if (GetDirectoriesSafe(_currentRoot, out var dirs))
                    {
                        _dirs = dirs!;
                    }
                    break;
            }
            if (GetFilesSafe(_currentRoot, out var files))
            {
                _files = files!;
            }
            _parentDir = new ExtendedDirectoryInfo(path);
            ResetDataGrid();
        }
        private void ResetDataGrid()
        {
            ItemsDataGridView.Rows.Clear();

            if (_currentRoot != "" && _currentRoot != _parentDir.Base.FullName)
            {
                AddLinkToParent();
            }
            
            foreach (var dir in _dirs)
            {
                var row = new DataGridViewRow
                {
                    Cells =
                    {
                        new DataGridViewTextBoxCell {Value = dir.Base.Name},
                        new DataGridViewTextBoxCell {Value = dir.Base.LastAccessTime.ToString(CultureInfo.CurrentCulture)},
                        new DataGridViewTextBoxCell {Value = "dir"},
                        new DataGridViewTextBoxCell
                        {
                            Value = dir.Size == -1 ? "Calculating" : $"{Utils.ConvertTo(dir.Size, MemoryUnit):0.00}"
                        }
                    }
                };
                dir.SizeCalculated += () =>
                {
                    if (_dirs.Contains(dir) && row.Cells[3] != null)
                    {
                        row.Cells[3].Value = $"{Utils.ConvertTo(dir.Size, MemoryUnit):0.00}";
                    }
                };
                ItemsDataGridView.Rows.Add(row);
            }

            ItemsDataGridView.Rows.AddRange(_files.Select(file => new DataGridViewRow
            {
                Cells =
                {
                    new DataGridViewTextBoxCell {Value = file.Name},
                    new DataGridViewTextBoxCell {Value = file.LastAccessTime.ToString(CultureInfo.CurrentCulture) },
                    new DataGridViewTextBoxCell {Value = file.Extension},
                    new DataGridViewTextBoxCell {Value = $"{Utils.ConvertTo(file.Length, MemoryUnit):0.00}"}
                }
            }).ToArray());
        }

        private void AddLinkToParent()
        {
            ItemsDataGridView.Rows.Add(
                new DataGridViewRow{
                    Cells = {
                        new DataGridViewTextBoxCell {Value = ".."},
                        new DataGridViewTextBoxCell {Value = ""},
                        new DataGridViewTextBoxCell {Value = ""},
                        new DataGridViewTextBoxCell {Value = ""}
                    }
                });
        }

        private void ItemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = ItemsDataGridView.SelectedRows[0];
            if (selected.Cells[2].Value.ToString() != "dir" && !(selected.Index == 0 && selected.Cells[0].Value.ToString() == ".."))
            {
                return;
            }
            
            
            if (selected.Index == 0 && selected.Cells[0].Value.ToString() == "..")
            {
                _parentDir = new ExtendedDirectoryInfo(_parentDir.Base.Parent?.FullName ?? _currentRoot);
            }
            else
            {
                _parentDir = _dirs.Find(dir => dir.Base.Name == selected.Cells[0].Value.ToString());
            }

            PathStripLabelValue.Text = _parentDir.Base.FullName;
            if (GetDirectoriesSafe(_parentDir.Base.FullName, out var dirs))
            {
                _dirs = dirs!;
            }
            if (GetFilesSafe(_parentDir.Base.FullName, out var files))
            {
                _files = files!;
            }
            ResetDataGrid();
        }

        private bool GetDirectoriesSafe(string path, out List<ExtendedDirectoryInfo>? directories)
        {
            try
            {
                directories = Directory.GetDirectories(path).Select(dir => new ExtendedDirectoryInfo(dir)).ToList();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to get directories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e.Message);
                directories = null;
                return false;
            }
        }
        
        private bool GetFilesSafe(string path, out List<FileInfo>? files)
        {
            try
            {
                files = Directory.GetFiles(path).Select(filename => new FileInfo(filename)).ToList();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to get files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e.Message);
                files = null;
                return false;
            }
        }
    }
}