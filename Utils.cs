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
                           .Sum(fi => fi.Length) +
                       dir.GetDirectories()
                           .Sum(GetDirectorySize);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return 0;
            }
        }
        
        public static double ConvertTo(long value, MemoryUnit unit) => value / Math.Pow(1024, (long)unit);

        public enum MemoryUnit
        {
            Bytes,
            KBytes,
            MBytes,
            GBytes
        }
    }
}