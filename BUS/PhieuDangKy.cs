using DAO;
using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuDangKy
    {
        public static List<PhieuDangKyDTO> loadDSPhieuDangKy()
        {
            return PhieuDangKyDB.loadDSPhieuDangKy();
        }
        public static ThongTinPhieuDangKyDTO loadThongTinPhieuDangKy(string maPhieu)
        {
            return PhieuDangKyDB.loadThongTinPhieuDangKy(maPhieu);
        }
        public static string TaoPhieuDKy(Models.PhieuDangKy phieu)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            int count = context.PhieuDangKies.ToList().Count();
            string maph = string.Concat("ID0", count.ToString());
            phieu.MaPhieuDk = maph;
            if (DAO.PhieuDangKyDB.taoPhieuDKyDB(phieu))
            {
                return maph;
            }
            return null;
        }
        public static List<Models.PhieuDangKy> load_PhieuDKyCuaKH(string makh)
        {
            return DAO.PhieuDangKyDB.loadPhieuDky_KH(makh);
        }
    }
}
