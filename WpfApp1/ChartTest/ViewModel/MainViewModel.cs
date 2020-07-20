using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ChartTest.Controls;
using OxyPlot;

namespace ChartTest.ViewModel
{
    class MainViewModel
    {
        public MainViewModel()
        {
            this.Title = "ReadFileExample";

            DirectoryInfo DataDirectory = new DirectoryInfo("Data");
            if (!DataDirectory.Exists)
            {
                DataDirectory.Create();
            }

            FileInfo[] DataFiles = DataDirectory.GetFiles();

            /*            List<PointListBoxItem> list = new List<PointListBoxItem>();

                        foreach (FileInfo DataFile in DataFiles)
                        {               
                            list.Add(new PointListBoxItem(DataFile));
                        }
                        this.Datas = list;*/

            List<List<PointListBoxItem>> list = new List<List<PointListBoxItem>>();

            for(int i=0; i<DataFiles.Length; i++)
            {
                List<PointListBoxItem> pi = new List<PointListBoxItem>();
                pi.Add(new PointListBoxItem(DataFiles[i]));

                if (i%2 != 0)
                {
                    list.Add(pi);
                    pi = null;
                }
            }

            List<PointListBoxItem> result = new List<PointListBoxItem>();

           for (int i=0; i<list.Count; i++)
            {
                result.Add(list[i][0]);
            }
            Datas = result;
        }

            
        public string Title { get; private set; }
        public IList<DataPoint> Points { get; private set; }
        public List<PointListBoxItem> Datas { get; private set; }

    }
}
