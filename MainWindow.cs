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
        private const string _root = @"C:\Users\";
        private bool _findAllUsers = false;

        private List<User> _users;
        public MainWindow()
        {
            InitializeComponent();

            _users = GetUsers();
        }

        private List<User> GetUsers()
        {
            // Get All users using WMI
            var allUsers = new ManagementObjectSearcher(@"SELECT * FROM Win32_UserAccount").Get();
            
            var filteredUsers = allUsers.Cast<ManagementObject>().Where( user =>
            {
                if (_findAllUsers)
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
            return Directory.Exists(_root + user) ? _root + user : string.Empty;
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BriefReportBtn_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}