using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;
namespace BUS
{
    public class CTPhieuDangKy
    {
        public static void TaoCTPhieuDKy(ChiTietDangKy ctphieu)
        {
            DAO.CTPhieuDangKyDB.themCTPhieuDKy(ctphieu);
        }
        public static List<Models.ChiTietDangKy> LoadCTcuaKH(string maphieu)
        {
           return DAO.CTPhieuDangKyDB.load_CTDKy(maphieu);

        }
        public static List<Models.ChiTietDangKy> LoadLichTiem(string makh)
        {
            return DAO.CTPhieuDangKyDB.load_LichTiem(makh);
        }
    }
}
