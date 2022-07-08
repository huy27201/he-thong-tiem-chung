using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MHChung.xaml
    /// </summary>
    public partial class MHChung : Window
    {
        public MHChung()
        {
            InitializeComponent();
        }

        private void Load_MHChinhNV(object sender, RoutedEventArgs e)
        {
            MHChinhNV mh = new MHChinhNV();
            mh.Show();
            Close();
        }
        private void Load_MHChinhKH(object sender, RoutedEventArgs e)
        {
            MHChinhKH mh = new MHChinhKH();
            mh.Show();
            Close();
        }
    }
}
