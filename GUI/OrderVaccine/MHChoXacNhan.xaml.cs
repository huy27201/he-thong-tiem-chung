using System;
using Models;
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
using DTO;

namespace GUI.OrderVaccine
{
    /// <summary>
    /// Interaction logic for WaitForApprove.xaml
    /// </summary>
    public partial class WaitForApprove : Window
    {
        private List<ChiTietPhieuMuaDTO> ListChiTietPhieuMuaDTO = new List<ChiTietPhieuMuaDTO>();
        private PhieuMua phieuMua;
        public WaitForApprove()
        {
            InitializeComponent();

        }
        public WaitForApprove(PhieuMua message)
        {
            InitializeComponent();
            phieuMua = message;
            BUS.ChiTietPhieuMua ctphieumuabus = new BUS.ChiTietPhieuMua();
            BUS.KhachHang khachhangbus = new BUS.KhachHang();
            ListChiTietPhieuMuaDTO = ctphieumuabus.getCTPhieuMuasDTO(phieuMua.MaPhieuMua);
            ListVaccineToBuyDataGrid.ItemsSource = ListChiTietPhieuMuaDTO;
            var khachhang = khachhangbus.getKhachHang(phieuMua.MaKh);
            makh.Text = khachhang.MaKh;
            ngaythang.Text = khachhang.NgaySinh.ToString();
            diachi.Text = khachhang.DiaChi;
            dienthoai.Text = khachhang.SoDt;
            hoten.Text = khachhang.HoTen;
            tinhtrang.Text = phieuMua.TrangThai;
        }

        private void Huy_Click(object sender, RoutedEventArgs e)
        {
            if (phieuMua.TrangThai == "Đang chờ")
            {
                BUS.ChiTietPhieuMua chiTietPhieuMua = new BUS.ChiTietPhieuMua();
                BUS.PhieuMua phieumuaBUS = new BUS.PhieuMua();
                chiTietPhieuMua.deleteListCTPhieuMua(phieuMua.MaPhieuMua);
                phieumuaBUS.deletePhieuMua(phieuMua.MaPhieuMua);
                MessageBox.Show("Huy thanh cong");
                Close();
            }
            else
            {
                MessageBox.Show("Khong the huy");
            }
        }
    }
}
