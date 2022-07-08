using DTO;
using BUS;
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
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        private List<ChiTietPhieuMuaDTO> ListChiTietPhieuMuaDTO = new List<ChiTietPhieuMuaDTO>();
        private string MaPhieuMua;
        public Information()
        {
            
            InitializeComponent();
            checkboxTV.IsChecked = true;
        }
        public Information(List<ChiTietPhieuMuaDTO> listctphieumua, string maphieumua)
        {
            
            InitializeComponent();
            checkboxTV.IsChecked = true;
            ListChiTietPhieuMuaDTO = listctphieumua;
            MaPhieuMua = maphieumua;
            ListVaccineToBuyDataGrid.ItemsSource = ListChiTietPhieuMuaDTO;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            InformationOther form = new InformationOther(ListChiTietPhieuMuaDTO, MaPhieuMua);
            form.Show();
            Close();
        }

        private void btnTiepTuc_Click(object sender, RoutedEventArgs e)
        {
            string makh = textboxMAKH.Text;
            BUS.KhachHang customerbus = new BUS.KhachHang();
            BUS.PhieuMua phieumuabus = new BUS.PhieuMua();
            BUS.ChiTietPhieuMua ctphieumuabus = new BUS.ChiTietPhieuMua();
            //check makh
           
                if (customerbus.checkMAKH(makh))
                {
                    MessageBox.Show("Ma khach hang hop le!");
                    Models.PhieuMua pm = new Models.PhieuMua()
                    {
                        MaPhieuMua = MaPhieuMua,
                        TrangThai = "Đang chờ",
                        MaKh = makh
                    };
                //update phieumua
               
                phieumuabus.updatePhieuMua(pm);
                //add chitietphieumua
                ctphieumuabus.addListCTPhieuMua(ListChiTietPhieuMuaDTO);
                //move on form WaitForApprove
                WaitForApprove form = new WaitForApprove(pm);
               
                form.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ma khach hang khong hop le!");
                }
            
        }
        private void ReturnToOderVaccine(object sender, MouseButtonEventArgs e)
        {
            OrderVaccine orderVaccine = new OrderVaccine(ListChiTietPhieuMuaDTO, MaPhieuMua);
            orderVaccine.Show();
            Close();
        }
    }
}
