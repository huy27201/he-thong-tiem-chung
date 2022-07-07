using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class KhachHang
    {
        public KhachHangDB customerDAO { get; set; }

        public KhachHang()
        {
            customerDAO = new KhachHangDB();
        }
        public List<Models.KhachHang> getCustomerList()
        {
            var customerList = customerDAO.getCustomers();
            return customerList;
        }
        public bool checkMAKH(string MaKH)
        {
            if(customerDAO.findCustomers(MaKH) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addCustomers(Models.KhachHang kh)
        {
            customerDAO.addCustomers(kh);  
        }
    }
}
