using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace FolderScanner
{
    public partial class MainWindow : Form
    {
        private const string Root = @"C:\Users\";
        private const string SharedElementsCaption = "Other elements";
        private const bool FindAllUsers = false;
        

        private List<User> _users;
        
        public MainWindow()
        {
            InitializeComponent();
            _users = GetUsers();

            FillItemsList();

            GetSharedFolderNames();
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
            if (ItemsList.SelectedItem.ToString() == SharedElementsCaption)
            {
                return;  // TODO setShared
            }
            
            var result = _users.Find(user => user.Caption == ItemsList.SelectedItem.ToString());
            if (result == null)
            {
                MessageBox.Show($"User {ItemsList.SelectedItem} not found", "Undefined Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO setUser
            
        }

        private void BriefReportBtn_Click(object sender, EventArgs e)
        {
            
        }


        private List<string> GetSharedFolderNames()
        {
            return Directory.GetDirectories(Root)
                .Where(dir => !_users.Exists(user => user.HomeDirectory == dir))
                .ToList();
        }
        
    }
}