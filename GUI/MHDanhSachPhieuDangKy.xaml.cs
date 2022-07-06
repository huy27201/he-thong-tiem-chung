﻿using BUS;
using DTO;
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
    /// Interaction logic for RegistrationFormDetail.xaml
    /// </summary>
    public partial class RegistrationFormDetail : Window
    {
        private string maPhieuDangKy;
        private ThongTinPhieuDangKyDTO thongTinPhieuDangKy;
        public RegistrationFormDetail()
        {
            InitializeComponent();
        }
        public RegistrationFormDetail(string maPhieuDangKy) : this()
        {
            this.maPhieuDangKy = maPhieuDangKy;
            thongTinPhieuDangKy = PhieuDangKy.loadThongTinPhieuDangKy(maPhieuDangKy);
            DataContext = thongTinPhieuDangKy;

        }

        private void ReturnToRegistrationFormList(object sender, MouseButtonEventArgs e)
        {
            RegistrationFormList registrationFormListWindow = new RegistrationFormList();
            registrationFormListWindow.Show();
            Close();
        }
    }
}