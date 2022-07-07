using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class KhachHangDB
    {
        private HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<KhachHang> getCustomers()
        {
            var customerList = context.KhachHangs.ToList();
            return customerList;
        }
        public void addCustomers(KhachHang kh)
        {
            context.KhachHangs.Add(kh);
            context.SaveChanges();
        }
        public KhachHang findCustomers(string MaKH)
        {
            return context.KhachHangs.Find(MaKH);
        }
    }
}
