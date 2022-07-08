using DTO;
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
        private List<ChiTietPhieuMuaDTO> ListChiTietPhieuMuaDTO = new List<ChiTietPhieuMuaDTO>();
        private string MaPhieuMua;
        public InformationOther()
        {
            
            InitializeComponent();
            checkkh.IsChecked = true;
        }
        public InformationOther(List<ChiTietPhieuMuaDTO> listctphieumua, string maphieumua)
        {
            InitializeComponent();
            checkkh.IsChecked = true;
            ListChiTietPhieuMuaDTO = listctphieumua;
            MaPhieuMua = maphieumua;
            ListVaccineToBuyDataGrid.ItemsSource = ListChiTietPhieuMuaDTO;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            Information form = new Information(ListChiTietPhieuMuaDTO, MaPhieuMua);
            form.Show();
            Close();
        }
        private void ReturnToOderVaccine(object sender, MouseButtonEventArgs e)
        {
            OrderVaccine orderVaccine = new OrderVaccine(ListChiTietPhieuMuaDTO, MaPhieuMua);
            orderVaccine.Show();
            Close();
        }
        private string CreateMaKhachHang()
        {
            BUS.KhachHang pnBus = new BUS.KhachHang();
            List<Models.KhachHang> ListKhachHang = pnBus.getCustomerList();
            int index = ListKhachHang.Count;
            string MaKhachHang = "ID";
            for (int i = (int)Math.Floor(Math.Log10(index)) + 1; i < 3; i++)
            {
                MaKhachHang += "0";
            }
            return MaKhachHang + index.ToString();
        }
        private void btnTiepTuc_Click(object sender, RoutedEventArgs e)
        {
            BUS.KhachHang khbus = new BUS.KhachHang();
            BUS.PhieuMua phieumuabus = new BUS.PhieuMua();
            BUS.ChiTietPhieuMua ctphieumuabus = new BUS.ChiTietPhieuMua();
            //add khachhang
            KhachHang kh = new KhachHang()
            {
                MaKh = CreateMaKhachHang(),
                HoTen =tbHoTen.Text,
                NgaySinh=Convert.ToDateTime(tbNgaySinh.Text),
                DiaChi = tbDiaChi.Text,
                SoDt = tbSDT.Text
            };
            khbus.addCustomers(kh);
            //update phieumua
            Models.PhieuMua pm = new Models.PhieuMua()
            {
                MaPhieuMua = MaPhieuMua,
                TrangThai = "Đang chờ",
                MaKh = kh.MaKh
            };
            phieumuabus.updatePhieuMua(pm);
            //add list chitietphieumua
            ctphieumuabus.addListCTPhieuMua(ListChiTietPhieuMuaDTO);
            //move on form WaitForApprove
            WaitForApprove form = new WaitForApprove(pm);
            form.Show();
            Close();
        }
    }
}
