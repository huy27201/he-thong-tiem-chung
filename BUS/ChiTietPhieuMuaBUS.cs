using System;
using Models;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuMuaBUS
    {
        ChiTietPhieuMuaDAO ctpmDAO = new ChiTietPhieuMuaDAO();
        public List<ChiTietPhieuMua> getCTPhieuMuas(string MaPhieuMua)
        {
            return ctpmDAO.getCTPhieuMuas(MaPhieuMua);
        }
        public void addCTPhieuMua(ChiTietPhieuMua ctpm)
        {
            ctpmDAO.addCTPhieuMua(ctpm);
        }
        public void addListCTPhieuMua(List<ChiTietPhieuMua> listCTPM)
        {
            foreach (ChiTietPhieuMua ctpm in listCTPM)
            {
                ctpmDAO.addCTPhieuMua(ctpm);
            }    
        }
    }
}
