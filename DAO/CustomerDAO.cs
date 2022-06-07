using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CustomerDAO
    {
        private string connectionString = "";
        private SqlConnection connection;
        private SqlCommand command;

        public DataSet getCustomers()
        {
            DataSet customerList = new DataSet();

            // sql command

            return customerList;
        }
    }
}
