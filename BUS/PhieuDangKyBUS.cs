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
    public class PhieuDangKyBUS
    {

        public PhieuDangKyBUS()
        {

        }
        public static List<PhieuDangKyDTO> loadDSPhieuDangKy()
        {
            return PhieuDangKyDAO.loadDSPhieuDangKy();
        }
    }
}
