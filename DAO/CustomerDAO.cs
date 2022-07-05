using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class CustomerDAO
    {
        private HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<KhachHang> getCustomers()
        {
            var customerList = context.KhachHangs.ToList();
            return customerList;
        }
    }
}
