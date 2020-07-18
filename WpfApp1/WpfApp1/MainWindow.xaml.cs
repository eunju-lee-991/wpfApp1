using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Controls;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            DirectoryInfo root = new DirectoryInfo(@"C:\Users\이경민\Documents\workspace-spring-tool-suite-4-4.7.0.RELEASE");

            List<DirectoryTreeViewItem> list = new List<DirectoryTreeViewItem>();

            foreach (DirectoryInfo directoryInfo in root.GetDirectories())
            {
                list.Add(new DirectoryTreeViewItem(directoryInfo));
            }

            MyTreeView.ItemsSource = list;
        }

        private void selectItem(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
