using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuMuaDAO
    {

        HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<ChiTietPhieuMua> getCTPhieuMuas(string MaPhieuMua)
        {
            var phieumuaList = context.ChiTietPhieuMuas
                .Where(x => x.MaPhieuMua == MaPhieuMua)
                .ToList();
            return phieumuaList;
        }
        public void addCTPhieuMua(ChiTietPhieuMua ctpm)
        {
            context.ChiTietPhieuMuas.Add(ctpm);
            context.SaveChanges();
        }
    }
}
