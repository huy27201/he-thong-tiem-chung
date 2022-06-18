﻿using BUS;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CustomerBUS customerBus { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            customerBus = new CustomerBUS();
        }

        private void ButtonGetCustomers_Click(object sender, RoutedEventArgs e)
        {
            List<KhachHang> customerList = customerBus.getCustomerList();

            // display
            Name.Text = customerList[0].HoTen;
            
        }
    }
}