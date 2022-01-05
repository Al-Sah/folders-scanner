using System;
using System.IO;
using System.Management;
using System.Threading;

namespace FolderScanner
{
    public class User
    {
        public bool Disabled { get; }
        public bool Lockout { get; }
        public string Domain { get; }
        public string Name { get; }
        public string Caption { get; }
        public string HomeDirectory { get; }
        public long SpaceUsage { get; private set; }
        public bool SpaceUsageValid { get; private set; }

        public User(ManagementObject user, string home)
        {
            Disabled = (bool) user["Disabled"];
            Lockout = (bool) user["Lockout"];
            
            Domain = user["Domain"].ToString();
            Name = user["Name"].ToString();
            Caption = user["Caption"].ToString();
            
            HomeDirectory = home;

            if (HomeDirectory == string.Empty)
            {
                SpaceUsage = -1;
                SpaceUsageValid = true;
            }
            else
            {
                SpaceUsageValid = false;
                ThreadPool.QueueUserWorkItem( _ =>
                {
                    SpaceUsage = Utils.GetDirectorySize(new DirectoryInfo(HomeDirectory));
                    SpaceUsageValid = true;
                });
            }
        }
    }
}