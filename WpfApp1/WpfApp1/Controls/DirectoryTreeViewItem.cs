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

            /*            List<DirectoryTreeViewItem> list = new List<DirectoryTreeViewItem>();

                        foreach (DirectoryInfo dirInfo in di.GetDirectories())
                        {
                            list.Add(new DirectoryTreeViewItem(dirInfo));
                        }
                        this.ItemsSource = list;*/

            List<DirectoryInfo> list = new List<DirectoryInfo>();


            foreach (DirectoryInfo dirInfo in di.GetDirectories())
            {
                list.Add(dirInfo);
            }
            this.ItemsSource = list;
        }

        protected override void OnExpanded(RoutedEventArgs e)
        {
            List<DirectoryTreeViewItem> list = new List<DirectoryTreeViewItem>();

            foreach (DirectoryInfo dir in MyDirectoryInfo.GetDirectories())
            {
                list.Add(new DirectoryTreeViewItem(dir));
            }
            this.ItemsSource = list;

        }

        public DirectoryInfo GetDirectoryInfo()
        {
            return MyDirectoryInfo;
        }
    }
}
