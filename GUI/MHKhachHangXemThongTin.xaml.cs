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
    /// Interaction logic for CustomerInfo.xaml
    /// </summary>
    public partial class MHKhachHangXemThongTin : Window
    {
        public MHKhachHangXemThongTin()
        {
            InitializeComponent();
        }

        private void load_PhieuDKy(object sender, RoutedEventArgs e)
        {
            dgvDSPhieuDky.ItemsSource = BUS.PhieuDangKy.load_PhieuDKyCuaKH(MHThongTinDangKy.makh);
            dgvDSPhieuDky.Columns[4].MaxWidth = 0;
            dgvDSPhieuDky.Columns[5].MaxWidth = 0;

        }

        private void load_LichTiem(object sender, RoutedEventArgs e)
        {
            dgvDSLichTiem.ItemsSource = BUS.CTPhieuDangKy.LoadLichTiem(MHThongTinDangKy.makh);
            dgvDSLichTiem.Columns[4].MaxWidth = 0;
        }
    }
}
