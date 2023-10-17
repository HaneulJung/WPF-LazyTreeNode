using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_LazyTreeNode.Utils
{
    public static class ToggleImageUtils
    {
        static BitmapImage GetBitmapImageByFileName(string fileName)
        {
            return new BitmapImage(new Uri($"./../Images/{fileName}", UriKind.Relative));
        }

        public static (BitmapImage? openedImage, BitmapImage? closedImage) GetExplorers(ExplorerType explorerType)
        {
            BitmapImage? openedImage = null;
            BitmapImage? closedImage = null;

            switch (explorerType)
            {
                case ExplorerType.Drive:
                    openedImage = GetBitmapImageByFileName("opened-drive.png");
                    closedImage = GetBitmapImageByFileName("closed-drive.png");
                    break;
                case ExplorerType.Directory:
                    openedImage = GetBitmapImageByFileName("opened-folder.png");
                    closedImage = GetBitmapImageByFileName("closed-folder.png");
                    break;
                case ExplorerType.File:
                    openedImage = null;
                    closedImage = GetBitmapImageByFileName("file.png");
                    break;
            }

            return (openedImage, closedImage);
        }
    }

    public enum ExplorerType
    {
        Drive, Directory, File
    }
}
