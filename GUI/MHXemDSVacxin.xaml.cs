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
    public partial class MHXemDSVacxin : Window
    {
        public MHXemDSVacxin()
        {
            InitializeComponent();
        }
        private void ReturnToRegistrationFormList(object sender, MouseButtonEventArgs e)
        {
            RegistrationFormList registrationFormListWindow = new RegistrationFormList();
            registrationFormListWindow.Show();
            Close();
        }

        private void LoadCBB_LoaiVacxin(object sender, RoutedEventArgs e)
        {
            List<string> LoaiVacxin = new List<string>() { "Lẻ", "Gói", "Tất cả" };
            cbbLoaiVacxin.ItemsSource = LoaiVacxin;
        }

        private void cbbLoaiVacxin_SelectionChangedCommited(object sender, SelectionChangedEventArgs e)
        {
            string loai = cbbLoaiVacxin.SelectedItem.ToString();
            if (loai == "Lẻ")
            {
                dgvDSVX.ItemsSource = BUS.Vaccine.loadVacxinLe();
                dgvDSVX.Columns[4].MaxWidth = 0;
            }
            else if (loai == "Gói")
            {
                dgvDSVX.ItemsSource = BUS.Vaccine.loadVacxinGoi();
                dgvDSVX.Columns[4].MaxWidth = 0;
            }
            else
            {
                dgvDSVX.ItemsSource = BUS.Vaccine.loadVacxin();
                dgvDSVX.Columns[4].MaxWidth = 0;
            }
        }


    }
}
