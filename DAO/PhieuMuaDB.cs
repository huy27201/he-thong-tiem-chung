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
        public void updatePhieuMua(PhieuMua phieuMua)
        {
            var std = context.PhieuMuas.Find(phieuMua.MaPhieuMua);
            std.TrangThai = phieuMua.TrangThai;
            std.MaKh = phieuMua.MaKh;
            context.SaveChanges();
        }
        public void deletePhieuMua(string maPhieuMua)
        {
            var std = context.PhieuMuas.Find(maPhieuMua);
            context.PhieuMuas.Remove(std);
        }
    }
}
