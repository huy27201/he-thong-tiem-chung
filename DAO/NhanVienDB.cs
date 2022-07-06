using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDB
    {
        private static HTTiemChungDBContext context = new HTTiemChungDBContext();
        public static List<NhanVien> LayDSNhanVien()
        {
            return context.NhanViens.ToList();
        }
        public static NhanVien LayChiTietNhanVien(String MaNV) 
        {
            return context.NhanViens.Find(MaNV);
        }

    }
}
