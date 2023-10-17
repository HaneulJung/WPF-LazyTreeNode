using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LazyTreeNode.Models;
using WPF_LazyTreeNode.Utils;

namespace WPF_LazyTreeNode.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<LazyTreeNode> PathNodes { get; set; }

        public LazyTreeNode CreateNode(string key, string text, ExplorerType explorerType)
        {
            var images = ToggleImageUtils.GetExplorers(explorerType);

            var node = new LazyTreeNode { Key = key, Text = text };
            node.OnExpanded += Node_OnExpanded;
            node.OpenedImage = images.openedImage;
            node.ClosedImage= images.closedImage;

            if (DirectoryUtils.IsDirectoryOrFileExists(key))
            {
                node.AddDummyNode();
            }

            return node;
        }

        private void Node_OnExpanded(LazyTreeNode node)
        {
           // 하위 디렉토리
           foreach (var di in DirectoryUtils.GetDirectories(node.Key))
            {
                node.Children.Add(CreateNode(di.FullName, di.Name, ExplorerType.Directory));
            }
            // 하위 파일
            foreach (var fi in DirectoryUtils.GetFiles(node.Key))
            {
                node.Children.Add(CreateNode(fi.FullName, fi.Name, ExplorerType.File));
            }
        }

        private void AddDriveNode()
        {
            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                PathNodes.Add(CreateNode(driveInfo.Name, driveInfo.Name, ExplorerType.Drive));
            }
        }

        public MainViewModel()
        {
            PathNodes = new ObservableCollection<LazyTreeNode>();

            AddDriveNode();
        }
    }
}
