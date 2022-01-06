using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FolderScanner.View
{
    public partial class ReportDialog : Form
    {

        private readonly List<User> _users;

        public Action? Ready;

        private long _totalSize = -1;
        public ReportDialog(List<User> users)
        {
            _users = users;
            InitializeComponent();
        }

        public void Setup()
        {
            var parent = (MainWindow)Owner;
            {
                new Thread(() =>
                {
                    _totalSize = Utils.GetDirectorySize(new DirectoryInfo(@"C:\Users\"));
                    
                    while (parent.SharedSpaceUsage == -1)
                    {
                        Thread.Sleep(5);
                    }
                    foreach (var user in _users)
                    {
                        while (!user.SpaceUsageValid)
                        {
                            Thread.Sleep(5);
                        }
                    }

                    _users.Sort((a, b) => a.SpaceUsage.CompareTo(b.SpaceUsage));
                    ItemsListBox.Items.AddRange(_users.Select(user => user.Name).ToArray());
                    ItemsListBox.Items.Add("Shared");
                    UsersCountLabelValue.Text = parent.UsersCount.ToString();
                    Ready?.Invoke();
                }){IsBackground = true}.Start();   
            }
        }
        
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ItemsListBox.SelectedItem.ToString();
            var user = _users.Find(user => user.Name == item);
            
            var parent = (MainWindow)Owner;
            if (user == null)
            {
                PathLabelValue.Text = @"C:\Users\";
                SpaceUsedLabelValue.Text = $"{Utils.ConvertTo(parent.SharedSpaceUsage, parent.MemoryUnit):0.00} \nIn {parent.MemoryUnit}";
                ItemLabelValue.Text = "Shared";
                return;
            }
            PathLabelValue.Text = user.HomeDirectory;
            SpaceUsedLabelValue.Text = $"{Utils.ConvertTo(user.SpaceUsage, parent.MemoryUnit):0.00} \nIn {parent.MemoryUnit}";
            ItemLabelValue.Text = $"User '{user.Name}'";
        }

        private void ReportDialog_Load(object sender, EventArgs e)
        {
            var memoryUnit = ((MainWindow) Owner).MemoryUnit;
            GeneralSpaceUsedLabelValue.Text = $"{Utils.ConvertTo(_totalSize, memoryUnit):0.00} \nIn {memoryUnit}";
        }
    }
}