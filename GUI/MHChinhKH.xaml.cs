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
    /// Interaction logic for MHChinh.xaml
    /// </summary>
    public partial class MHChinhKH : Window
    {
        public MHChinhKH()
        {
            InitializeComponent();
        }

        private void Load_MHDanhSachPhieuDangKy(object sender, RoutedEventArgs e)
        {
            MHDanhSachPhieuDangKy mhDanhSachPhieuDangKy = new MHDanhSachPhieuDangKy();
            mhDanhSachPhieuDangKy.Show();
            Close();
        }

        private void Load_MHDangKyLichRanh(object sender, RoutedEventArgs e)
        {
            MHDangKyLichRanh mhDangKyLichRanh = new MHDangKyLichRanh();
            mhDangKyLichRanh.Show();
            Close();
        }

        private void Load_MHXemLichLamViec(object sender, RoutedEventArgs e)
        {
            MHXemLichLamViec mhXemLichLamViec = new MHXemLichLamViec(); 
            mhXemLichLamViec.Show();
            Close();
        }

        private void Load_MHSapXepLichLamViec(object sender, RoutedEventArgs e)
        {
            MHSapXepLichLamViec mhSapXepLichLamViec = new MHSapXepLichLamViec();
            mhSapXepLichLamViec.Show();
            Close();
        }

        private void Load_MHChonVaccine(object sender, RoutedEventArgs e)
        {
            OrderVaccine.OrderVaccine mh = new OrderVaccine.OrderVaccine();
            mh.Show();
            Close();
        }
    }
}
