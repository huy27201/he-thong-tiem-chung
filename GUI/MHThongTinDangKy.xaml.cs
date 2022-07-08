﻿using System;
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
    /// Interaction logic for SignUpVaccineFormDetail.xaml
    /// </summary>
    public partial class MHThongTinDangKy : Window
    {
        public MHThongTinDangKy()
        {
            InitializeComponent();
            Button btnDangKyTiem = new Button();
            btnDangKyTiem.Click += BtnDangKyTiem_Click;
        }
        public static string maphieu = "";
        public static string makh = "";
        private void BtnDangKyTiem_Click(object sender, RoutedEventArgs e)
        {

            throw new NotImplementedException();
        }
        private void ReturnToRegistrationFormList(object sender, MouseButtonEventArgs e)
        {
            RegistrationFormList registrationFormListWindow = new RegistrationFormList();
            registrationFormListWindow.Show();
            Close();
        }
        private bool checkIfAdult(DateTime date)
        {
            TimeSpan TS = DateTime.Now - (DateTime)datePickerDOB.SelectedDate.Value.Date;
            double age = TS.TotalDays / 365;
            if (age > 18)
            {
                return true;
            }
            return false;
        }
        private void BtnXacNhanThongTin_Click(object sender, RoutedEventArgs e)
        {
            KhachHang newCus = new KhachHang();
            newCus.SoDt = txtSDT.Text;
            newCus.HoTen = txtHoTen.Text;
            newCus.DiaChi = txtDiaChi.Text;
            newCus.NgaySinh = (DateTime)datePickerDOB.SelectedDate.Value.Date;
            string magh = "";
            // kiem tra thong tin nguoi giam ho
            if (!checkIfAdult((DateTime)newCus.NgaySinh))
            {
                if (txtSDTGH.Text == "" || txtTenGHo.Text == "" || txtQuanHe.Text == "")
                {
                    MessageBox.Show("Người tiêm chưa đủ 18 tuổi. Vui lòng nhập thông tin người giám hộ!");
                }
                else
                {
                    newCus.NgaySinh = (DateTime)datePickerDOB.SelectedDate.Value.Date;
                    NguoiGiamHo newGH = new NguoiGiamHo();
                    newGH.SoDt = txtSDTGH.Text;
                    newGH.HoTen = txtHoTen.Text;
                    newGH.MoiQuanHe = txtQuanHe.Text;
                    magh = GiamHo.createGiamHoBUS(newGH);

                }
            }
            // them ma giam ho cho khach hang
            if (magh != null)
            {
                CustomerBUS.updateNguoiGiamHo(newCus, magh);
            }
            // tao khach hang moi
            makh = CustomerBUS.createCustomerBUS(newCus);
            Models.PhieuDangKy pdk = new Models.PhieuDangKy();
            pdk.MaKh = newCus.MaKh;
            pdk.NgayDk = (DateTime.Now);
            // tao phieu dang ky moi
            maphieu = BUS.PhieuDangKy.TaoPhieuDKy(pdk);
            // hien thi form dang ky vaccine
            MHVaccineDangKy infovaccine = new MHVaccineDangKy();
            infovaccine.Show();
            this.Close();
            MessageBox.Show(String.Concat("Mã khách hàng của bạn là: ", makh));

        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
