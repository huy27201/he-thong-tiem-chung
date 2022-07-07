using System;
using Models;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuMua
    {
        ChiTietPhieuMuaDB ctpmDAO = new ChiTietPhieuMuaDB();
        public List<Models.ChiTietPhieuMua> getCTPhieuMuas(string MaPhieuMua)
        {
            return ctpmDAO.getCTPhieuMuas(MaPhieuMua);
        }
        public void addCTPhieuMua(Models.ChiTietPhieuMua ctpm)
        {
            ctpmDAO.addCTPhieuMua(ctpm);
        }
        public void addListCTPhieuMua(List<Models.ChiTietPhieuMua> listCTPM)
        {
            foreach (Models.ChiTietPhieuMua ctpm in listCTPM)
            {
                ctpmDAO.addCTPhieuMua(ctpm);
            }    
        }
    }
}
