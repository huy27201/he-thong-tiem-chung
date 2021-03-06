using BUS;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for RegistrationFormList.xaml
    /// </summary>
    public partial class MHDanhSachPhieuDangKy : Window
    {

        private BUS.PhieuDangKy phieuDangKyBUS;
        private List<string> registrationFormStatusList;
        private List<PhieuDangKyDTO> registrationForms;
        public MHDanhSachPhieuDangKy()
        {
            InitializeComponent();
            registrationFormStatusList = new List<string>()
            {
                "Tất cả",
                "Đã duyệt",
                "Chưa duyệt"
            };
            RegistrationFormStatusComboBox.ItemsSource = registrationFormStatusList;

            registrationForms = BUS.PhieuDangKy.loadDSPhieuDangKy();
            RegistrationFormDataGrid.ItemsSource = registrationForms;
        }
        private void LoadRegistrationFormDetail(object sender, MouseButtonEventArgs e)
        {
            string maPhieuDangKy = ((PhieuDangKyDTO)RegistrationFormDataGrid.SelectedItem).MaPhieuDangKy;
            MHChiTietPhieuDangKy registrationFormDetailScreen = new MHChiTietPhieuDangKy(maPhieuDangKy);
            registrationFormDetailScreen.Show();
            Close();
        }

        private void Load_MHChinh(object sender, MouseButtonEventArgs e)
        {
            MHChinhNV mh = new MHChinhNV();
            mh.Show();
            Close();
        }
    }
}
