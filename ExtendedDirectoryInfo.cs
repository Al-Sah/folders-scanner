using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FolderScanner
{
    public class ExtendedDirectoryInfo
    {
        public DirectoryInfo Base { get; }
        public long Size { get; private set; }
        
        public event Action? SizeCalculated;

        public ExtendedDirectoryInfo(string path )
        {
            Base = new DirectoryInfo(path);
            Size = -1;
            ThreadPool.QueueUserWorkItem( _ =>
            {
                Size = Utils.GetDirectorySize(Base);
                SizeCalculated?.Invoke();
            });
        }
    }
}