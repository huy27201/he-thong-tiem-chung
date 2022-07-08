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
    public partial class MHVaccineDangKy : Window
    {
        public MHVaccineDangKy()
        {

            InitializeComponent();
            Button btnXacNhan = new Button();
            btnXacNhan.Click += BtnXacNhan_Click;

        }
        HTTiemChungDBContext ctx = new HTTiemChungDBContext();

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
            cbbTenVacxin.ItemsSource = BUS.Vaccine.DKy_LoadVacxin();
        }
        private void btnThemVX_Click(object sender, RoutedEventArgs e)
        {
            Models.ChiTietDangKy ctphieu = new Models.ChiTietDangKy();
            ctphieu.DiaDiem = cbbDiaDiem.SelectedItem.ToString();
            ctphieu.MaPhieuDk = MHThongTinDangKy.maphieu;
            ctphieu.MaVaccine = cbbTenVacxin.SelectedItem.ToString();
            ctphieu.ThoiGianTiem = (DateTime)datePickerNgayTiem.SelectedDate.Value.Date;
            CTPhieuDangKy.TaoCTPhieuDKy(ctphieu);
            cbbDiaDiem.SelectedIndex = -1;
            cbbTenVacxin.SelectedIndex = -1;
            datePickerNgayTiem.SelectedDate = null;
            dgvCTPhieuDK.ItemsSource = null;
            dgvCTPhieuDK.ItemsSource = BUS.CTPhieuDangKy.LoadCTcuaKH(ctphieu.MaPhieuDk).Select(o => new {MaPhieuDangKy = o.MaPhieuDk, MaVaccine = o.MaVaccine, DiaDiemTiem = o.DiaDiem, NgayTiem = o.ThoiGianTiem});

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
            List<Models.ChiTietDangKy> result = new List<Models.ChiTietDangKy>();
            string maphieu = MHThongTinDangKy.maphieu;
            result = BUS.CTPhieuDangKy.LoadCTcuaKH(maphieu);
            dgvCTPhieuDK.ItemsSource = result;
        }

        private void LoadCBB_Vaccine(object sender, RoutedEventArgs e)
        {
            cbbTenVacxin.ItemsSource = BUS.Vaccine.DKy_LoadVacxin();
        }

        private void ButXemDSVX_Click(object sender, RoutedEventArgs e)
        {
            MHXemDSVacxin dsvx = new MHXemDSVacxin();
            dsvx.Show();
        }

        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công");
        }
    }
}
