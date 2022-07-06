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
using Models;
using BUS;
namespace GUI
{
    /// <summary>
    /// Interaction logic for SignUpVaccineForm_Info.xaml
    /// </summary>
    public partial class FormSignUpVaccine : Window
    {
        public FormSignUpVaccine()
        {

            InitializeComponent();
            Button btnXacNhan = new Button();
            btnXacNhan.Click += BtnXacNhan_Click;

        }

        private void BtnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            KhachHang newCustomer = new KhachHang();

            throw new NotImplementedException();
        }
        private void ReturnToRegistrationFormList(object sender, MouseButtonEventArgs e)
        {
            RegistrationFormList registrationFormListWindow = new RegistrationFormList();
            registrationFormListWindow.Show();
            Close();
        }
        private void loadDanhSachVX()
        {
            cbbTenVacxin.ItemsSource = VaccineBUS.getVaccineBUS();
        }
        private void btnThemVX_Click(object sender, RoutedEventArgs e)
        {

        }



        private void Load_ComboboxDiaDiem(object sender, RoutedEventArgs e)
        {
            List<string> diadiem = new List<string>()
            {
            "856 Tạ Quang Bửu P5 Q8 TPHCM",
            "22 Phạm Văn Đồng TPHCM",
            "123 Lê Duẩn TP HCM",
            "231 Hàng Xanh TPHCM"
            };
            cbbDiaDiem.ItemsSource = diadiem;
        }

        private void Load_ComboboxHinhThucTT(object sender, RoutedEventArgs e)
        {
            List<string> hinhthuc = new List<string>() { "Tiền mặt", "Trực tiếp" };
            cbbHinhThucThanhToan.ItemsSource = hinhthuc;
        }
        private void Load_CTPhieuDK(object sender, RoutedEventArgs e)
        {
            HTTiemChungDBContext ctx = new HTTiemChungDBContext();
            var result = from c in ctx.PhieuDangKies select new { MaPhieu= c.MaPhieuDk, MaKH = c.MaKh, TongTien = c.TongTien,NgayDangKy = c.NgayDk};
            dgvCTPhieuDK.ItemsSource = result.ToList();
        }
    }
}
