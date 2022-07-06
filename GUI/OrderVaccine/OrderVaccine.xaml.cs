﻿using BUS;
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
        private List<ChiTietPhieuMua> ListChiTietPhieuMua;
        private string MaPhieuMua;
        private string CreateMaPhieuMua()
        {
            PhieuMuaBUS pnBus = new PhieuMuaBUS();
            List<PhieuMua> ListPhieuMua = pnBus.getPhieuMuas();
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
            VaccineBUS vcBUS = new VaccineBUS();
            ListVaccine = vcBUS.getVaccines();
            ListVaccineDataGrid.ItemsSource = ListVaccine;
        }
        public OrderVaccine(List<ChiTietPhieuMua> listctphieumua, string maphieumua)
        {
            ListChiTietPhieuMua = listctphieumua;
            MaPhieuMua = maphieumua;
        }
        private void Huy_Click(object sender, RoutedEventArgs e)
        {
            if (MaPhieuMua != "")
            {
                PhieuMuaBUS pmbus = new PhieuMuaBUS();
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
                PhieuMua pm = new PhieuMua()
                {
                    MaPhieuMua = this.MaPhieuMua
                };
                PhieuMuaBUS pmBus = new PhieuMuaBUS();
                pmBus.addPhieuMua(pm);
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}