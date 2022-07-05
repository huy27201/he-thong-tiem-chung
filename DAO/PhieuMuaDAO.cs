using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuMuaDAO
    {
        HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<PhieuMua> getPhieuMuas()
        {
            var phieumuaList = context.PhieuMuas.ToList();
            return phieumuaList;
        }
        public void addPhieuMua(PhieuMua pm)
        {
            context.PhieuMuas.Add(pm);
            context.SaveChanges();
        }
        public PhieuMua findPhieuMua(string maPhieuMua)
        {
            return context.PhieuMuas.Find(maPhieuMua);
        }
    }
}
