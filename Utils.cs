using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FolderScanner
{
    public static class Utils
    {
        public static long GetDirectorySize(DirectoryInfo dir)
        {
            try
            {
                return dir.GetFiles()
                           .Sum(fi => fi.Length / 1024) +
                       dir.GetDirectories()
                           .Sum(GetDirectorySize);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return 0;
            }
        }
    }
}