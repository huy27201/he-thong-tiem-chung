using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuMua
    {
        public PhieuMuaDB phieumuaDAO { get; set; }

        public PhieuMua()
        {
            phieumuaDAO = new PhieuMuaDB();
        }
        public List<Models.PhieuMua> getPhieuMuas()
        {
            var phieumuaList = phieumuaDAO.getPhieuMuas();
            return phieumuaList;
        }
        public void addPhieuMua(Models.PhieuMua pm)
        {
            phieumuaDAO.addPhieuMua(pm);
        }
        public Models.PhieuMua findPhieuMua(string maPhieuMua)
        {
            return phieumuaDAO.findPhieuMua(maPhieuMua);
        }
        public void updatePhieuMua(Models.PhieuMua phieuMua)
        {
            phieumuaDAO.updatePhieuMua(phieuMua);
        }
        public void deletePhieuMua(string maPhieuMua)
        {
            phieumuaDAO.deletePhieuMua(maPhieuMua);
        }
    }
}
