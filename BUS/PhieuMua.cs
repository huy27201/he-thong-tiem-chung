using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuMuaBUS
    {
        public PhieuMuaDAO phieumuaDAO { get; set; }

        public PhieuMuaBUS()
        {
            phieumuaDAO = new PhieuMuaDAO();
        }
        public List<PhieuMua> getPhieuMuas()
        {
            var phieumuaList = phieumuaDAO.getPhieuMuas();
            return phieumuaList;
        }
        public void addPhieuMua(PhieuMua pm)
        {
            phieumuaDAO.addPhieuMua(pm);
        }
        public PhieuMua findPhieuMua(string maPhieuMua)
        {
            return phieumuaDAO.findPhieuMua(maPhieuMua);
        }
        public void updatePhieuMua(PhieuMua phieuMua)
        {
            phieumuaDAO.updatePhieuMua(phieuMua);
        }
        public void deletePhieuMua(string maPhieuMua)
        {
            phieumuaDAO.deletePhieuMua(maPhieuMua);
        }
    }
}
