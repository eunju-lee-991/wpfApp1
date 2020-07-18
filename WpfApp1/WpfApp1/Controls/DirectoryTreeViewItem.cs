using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Controls
{
    class DirectoryTreeViewItem : TreeViewItem
    {
        private DirectoryInfo MyDirectoryInfo;

        private DirectoryTreeViewItem()
        {

        }

        public DirectoryTreeViewItem(DirectoryInfo di)
        {
            Header = di.Name;
            MyDirectoryInfo = di;

            List<DirectoryInfo> list2 = new List<DirectoryInfo>();

            foreach (DirectoryInfo dirInfo in di.GetDirectories())
            {
                list2.Add(dirInfo);
            }
            this.ItemsSource = list2;
        }

        protected override void OnExpanded(RoutedEventArgs e)
        {
            List< DirectoryTreeViewItem> list3 = new List<DirectoryTreeViewItem>();

            foreach (DirectoryInfo dir in MyDirectoryInfo.GetDirectories())
            {
                list3.Add(new DirectoryTreeViewItem(dir));
            }
            this.ItemsSource = list3;
        }

        public DirectoryInfo GetDirectoryInfo()
        {
            return MyDirectoryInfo;
        }
    }
}
