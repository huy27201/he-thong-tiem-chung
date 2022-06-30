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
        private List<string> registrationFormStatusList;
        private List<PhieuDangKy> registrationForms;
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

            registrationForms = new List<PhieuDangKy>()
            {
                new PhieuDangKy()
                {
                    MaPhieuDk = "01",
                    TongTien = 100000,
                    MaKh = "01",
                    NgayDk = new DateTime()
                }
            };
            RegistrationFormDataGrid.ItemsSource = registrationForms;
        }
    }
}
