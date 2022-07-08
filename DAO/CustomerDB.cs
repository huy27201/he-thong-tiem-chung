using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO
{
    public class CustomerDB
    {
        private HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<KhachHang> getCustomers()
        {
            var customerList = context.KhachHangs.ToList();
            return customerList;
        }
        public static string InsertCustomerDAO(KhachHang cus)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            int count = context.KhachHangs.ToList().Count();
            string makh = string.Concat("ID0", count.ToString());
            cus.MaKh = makh;
            context.KhachHangs.Add(cus);
            context.SaveChanges();
            if (context.KhachHangs.Find(makh) != null)
            {
                return makh;
            }
            return null;
        }
        public static bool updateNguoiGiamHoDAO(KhachHang kh, string magh)
        {
            using (var context = new HTTiemChungDBContext())
            {
                var temp = context.KhachHangs.SingleOrDefault(b => b.MaKh == kh.MaKh);
                if (temp != null)
                {
                    temp.GiamHo = magh;
                    try
                    {
                        context.SaveChanges();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return false;
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
