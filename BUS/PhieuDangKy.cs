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
    }
}
