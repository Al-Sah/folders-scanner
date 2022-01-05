using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace FolderScanner
{
    public partial class MainWindow : Form
    {
        private const string Root = @"C:\Users\";
        private const string SharedElementsCaption = "Other elements";
        private const bool FindAllUsers = false;

        private readonly List<User> _users;
        private string _lastSelection = string.Empty;

        private long _sharedSpaceUsage = -1;
        
        public MainWindow()
        {
            InitializeComponent();
            _users = GetUsers();
            ThreadPool.QueueUserWorkItem( _ => _sharedSpaceUsage = CalculateSharedItemsSpaceUsage());
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
            var selectedItem = String.Copy(ItemsList.SelectedItem.ToString());
            if (selectedItem == _lastSelection)
            {
                return;
            }
            _lastSelection = selectedItem;
                
            if (selectedItem == SharedElementsCaption)
            {
                SetSharedInformation();
                return;
            }
            var result = _users.Find(user => user.Caption == selectedItem);
            if (result == null) // TODO is it possible ?
            {
                MessageBox.Show($"User {ItemsList.SelectedItem} not found", "Undefined Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetUserInformation(result);
        }

        private void BriefReportBtn_Click(object sender, EventArgs e)
        {
            
        }

        
        private long CalculateSharedItemsSpaceUsage()
        {
            long res = Directory.GetDirectories(Root)
                .Where(dir => !_users.Exists(user => user.HomeDirectory == dir))
                .ToList()
                .Sum(dir => Utils.GetDirectorySize(new DirectoryInfo(dir)));

            res += Directory.GetFiles(Root).Sum(fi => fi.Length / 1024); // TODD size config
            return res;
        }
        
        private void SetSharedInformation()
        {
            const string noInfoStr = "- - - - -"; 
            HomeDirectoryLabelValue.Text = Root;
            DisabledLabelValue.Text = noInfoStr;
            LockoutLabelValue.Text = noInfoStr;
            NameLabelValue.Text = noInfoStr;
            CaptionLabelValue.Text = noInfoStr;
            
            if (_sharedSpaceUsage != -1)
            {
                SpaceUsedLabelValue.Text = _sharedSpaceUsage.ToString();
            }
            else
            {
                SpaceUsedLabelValue.Text = "Wait )";
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
                SpaceUsedLabelValue.Text = user.SpaceUsage.ToString();
            }
            else
            {
                SpaceUsedLabelValue.Text = "Wait )";
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
                SpaceUsedLabelValue.Invoke((MethodInvoker) delegate
                {
                    SpaceUsedLabelValue.Text = user.SpaceUsage.ToString();
                });
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
                while (_sharedSpaceUsage == -1)
                {
                    Thread.Sleep(10);
                }
                SpaceUsedLabelValue.Invoke((MethodInvoker) delegate
                {
                    SpaceUsedLabelValue.Text = _sharedSpaceUsage.ToString();
                });
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}