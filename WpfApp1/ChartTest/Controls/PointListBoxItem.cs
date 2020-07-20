using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChartTest.Controls
{
    class PointListBoxItem : ListBoxItem
    {
        private char _XY;
        public char XY
        {
            get => _XY;
            set
            {
                _XY = value;
            }
        }

        private FileInfo _MyFileInfo;
        public FileInfo MyFileInfo
        {
            get => _MyFileInfo;
            set
            {
                if(_MyFileInfo != value)
                {
                    _MyFileInfo = value;
                }
            }
        }

        public PointListBoxItem()
        {

        }

        public PointListBoxItem(FileInfo datafile)
        {            
            MyFileInfo = datafile;
            int idx = datafile.Name.IndexOf("_");
            _XY = datafile.Name[idx + 1];
            idx = datafile.Name.IndexOf("(");
            Content = datafile.Name.Substring(idx + 1);
        }
    }
}
