using DAO;
using System;
using System.Data;

namespace BUS
{
    public class CustomerBUS
    {
        public CustomerDAO customerDAO { get; set; }

        public CustomerBUS()
        {
            customerDAO = new CustomerDAO();
        }
        public DataSet getCustomerList()
        {
            var customerList = customerDAO.getCustomers();

            // logic

            return customerList;
        }
    }
}
