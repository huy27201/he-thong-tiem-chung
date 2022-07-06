using Models;
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

namespace GUI.OrderVaccine
{
    /// <summary>
    /// Interaction logic for InformationOther.xaml
    /// </summary>
    public partial class InformationOther : Window
    {
        private List<ChiTietPhieuMua> ListChiTietPhieuMua;
        private string MaPhieuMua;
        public InformationOther()
        {
            InitializeComponent();
        }
        public InformationOther(List<ChiTietPhieuMua> listctphieumua, string maphieumua)
        {
            ListChiTietPhieuMua = listctphieumua;
            MaPhieuMua = maphieumua;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            Information form = new Information();
            form.Show();
            Close();
        }
        private void ReturnToOderVaccine(object sender, MouseButtonEventArgs e)
        {
            OrderVaccine orderVaccine = new OrderVaccine(ListChiTietPhieuMua, MaPhieuMua);
            orderVaccine.Show();
            Close();
        }

        private void btnTiepTuc_Click(object sender, RoutedEventArgs e)
        {
            KhachHang kn = new KhachHang()
            {
                HoTen=tbHoTen.Text,
                NgaySinh=Convert.ToDateTime(tbNgaySinh.Text),
                DiaChi = tbDiaChi.Text,
                SoDt = tbSDT.Text
            };
        }
    }
}
