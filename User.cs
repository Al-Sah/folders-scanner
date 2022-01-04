using System;
using System.Management;

namespace FolderScanner
{
    public class User
    {
        public bool Disabled { get; }
        public bool Lockout;
        
        public string Domain;
        public string Name;
        public string Caption;

        public string HomeDirectory;

        public User(ManagementObject user, string home)
        {
            Disabled = (bool) user["Disabled"];
            Lockout = (bool) user["Lockout"];
            
            Domain = user["Domain"].ToString();
            Name = user["Name"].ToString();
            Caption = user["Caption"].ToString();
            
            HomeDirectory = home;
        }
        
    }
}