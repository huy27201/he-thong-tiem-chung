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

namespace GUI.OrderVaccine
{
    /// <summary>
    /// Interaction logic for OrderVaccine.xaml
    /// </summary>
    public partial class OrderVaccine : Window
    {
        private List<VaccineDTO> ListVaccine;
        private List<Models.ChiTietPhieuMua> ListChiTietPhieuMua;
        private string MaPhieuMua;
        private string CreateMaPhieuMua()
        {
            BUS.PhieuMua pnBus = new BUS.PhieuMua();
            List<Models.PhieuMua> ListPhieuMua = pnBus.getPhieuMuas();
            int index = ListPhieuMua.Count;
            string MaPhieuMua = "ID";
            for (int i = (int)Math.Floor(Math.Log10(index)) + 1; i < 3; i++)
            {
                MaPhieuMua += "0";
            }
            return MaPhieuMua + index.ToString();
        }
        public OrderVaccine()
        {
            InitializeComponent();
            BUS.Vaccine vcBUS = new BUS.Vaccine();
            ListVaccine = vcBUS.getVaccines();
            ListVaccineDataGrid.ItemsSource = ListVaccine;
        }
        public OrderVaccine(List<Models.ChiTietPhieuMua> listctphieumua, string maphieumua)
        {
            ListChiTietPhieuMua = listctphieumua;
            MaPhieuMua = maphieumua;
        }
        private void Huy_Click(object sender, RoutedEventArgs e)
        {
            if (MaPhieuMua != "")
            {
                BUS.PhieuMua pmbus = new BUS.PhieuMua();
                pmbus.deletePhieuMua(MaPhieuMua);
            }
            this.Close();
        }

        private void TiepTuc_Click(object sender, RoutedEventArgs e)
        {
            Information form = new Information(ListChiTietPhieuMua, MaPhieuMua);
            form.Show();
            Close();
        }

        private void ThemVaccine_Click(object sender, RoutedEventArgs e)
        {
            if (MaPhieuMua == "")
            {
                MaPhieuMua = CreateMaPhieuMua();
                Models.PhieuMua pm = new Models.PhieuMua()
                {
                    MaPhieuMua = this.MaPhieuMua
                };
                BUS.PhieuMua pmBus = new BUS.PhieuMua();
                pmBus.addPhieuMua(pm);
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
