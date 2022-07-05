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
    public partial class RegistrationFormList : Window
    {
        private PhieuDangKyBUS phieuDangKyBUS;
        private List<string> registrationFormStatusList;
        private List<PhieuDangKyDTO> registrationForms;
        public RegistrationFormList()
        {
            InitializeComponent();
            registrationFormStatusList = new List<string>()
            {
                "Tất cả",
                "Đã duyệt",
                "Chưa duyệt"
            };
            RegistrationFormStatusComboBox.ItemsSource = registrationFormStatusList;

            registrationForms = PhieuDangKyBUS.loadDSPhieuDangKy();
            RegistrationFormDataGrid.ItemsSource = registrationForms;
        }
        private void LoadRegistrationFormDetail(object sender, MouseButtonEventArgs e)
        {
            string maPhieuDangKy = ((PhieuDangKyDTO)RegistrationFormDataGrid.SelectedItem).MaPhieuDangKy;
            RegistrationFormDetail registrationFormDetailScreen = new RegistrationFormDetail(maPhieuDangKy);
            registrationFormDetailScreen.Show();
            Close();
        }
    }
}
