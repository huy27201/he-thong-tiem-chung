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
    /// Interaction logic for XemDSVX.xaml
    /// </summary>
    public partial class VaccineList : Window
    {
        public VaccineList()
        {
            InitializeComponent();
        }
        private void ReturnToRegistrationFormList(object sender, MouseButtonEventArgs e)
        {
            MHDanhSachPhieuDangKy registrationFormListWindow = new MHDanhSachPhieuDangKy();
            registrationFormListWindow.Show();
            Close();
        }
    }
}
