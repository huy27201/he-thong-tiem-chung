using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class CustomerBUS
    {
        public Customer customerDAO { get; set; }

        public CustomerBUS()
        {
            customerDAO = new Customer();
        }
        public List<KhachHang> getCustomerList()
        {
            var customerList = customerDAO.getCustomers();
            return customerList;
        }
        public static bool createCustomerBUS(KhachHang KH)
        {
            if (Customer.InsertCustomerDAO(KH) != null)
            {
                return true;
            }
            return false;
        }
        public static void updateNguoiGiamHo(KhachHang kh, string magh)
        {
            CustomerDAO.updateNguoiGiamHoDAO(kh, magh);
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
        public void addCustomers(KhachHang kh)
        {
            customerDAO.addCustomers(kh);  
        }
    }
}
