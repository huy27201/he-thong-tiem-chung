using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class CTPhieuDangKyDB
    {
        public static void themCTPhieuDKy(ChiTietDangKy ct)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            context.ChiTietDangKies.Add(ct);
            context.SaveChanges();
        }
        public static List<Models.ChiTietDangKy> load_CTDKy(string maphieu)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list = context.ChiTietDangKies.Where(c => c.MaPhieuDk == maphieu);
            return list.ToList();
        }
        public static List<Models.ChiTietDangKy> load_LichTiem(string makh)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list = context.ChiTietDangKies
             .Join(context.PhieuDangKies, ct => ct.MaPhieuDk, phieu => phieu.MaPhieuDk, (ct, phieu) => new
             {
                 Maphieu = phieu.MaPhieuDk,
                 Mavacxin = ct.MaVaccine,
                 DiaDiem = ct.DiaDiem,
                 NgayTiem = ct.ThoiGianTiem,
                 KhachHang = phieu.MaKh
             }).Where(x => x.KhachHang == makh && DateTime.Compare((DateTime)x.NgayTiem, DateTime.Today)>0)
            .Select(x => new ChiTietDangKy()
            {
                MaPhieuDk = x.Maphieu,
                MaVaccine = x.Mavacxin,
                DiaDiem = x.DiaDiem,
                ThoiGianTiem = x.NgayTiem
            }).ToList();
            return list;
        }
    }
}
