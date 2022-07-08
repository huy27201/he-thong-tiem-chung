using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuDangKyDB
    {
        private static HTTiemChungDBContext context = new HTTiemChungDBContext();

        public static List<PhieuDangKyDTO> loadDSPhieuDangKy()
        {
            var dsPhieuDangKy = context.PhieuDangKies
                            .Join(context.KhachHangs,
                                    phieuDangKy => phieuDangKy.MaKh,
                                    khachHang => khachHang.MaKh,
                                    (phieuDangKy, khachHang) => new PhieuDangKyDTO
                                    {
                                        MaPhieuDangKy = phieuDangKy.MaPhieuDk,
                                        HoTen = khachHang.HoTen,
                                        NgayDangKy = phieuDangKy.NgayDk,
                                    });
            return dsPhieuDangKy.ToList();
        }
        public static ThongTinPhieuDangKyDTO loadThongTinPhieuDangKy(string maPhieu)
        {
            var thongTinPhieuDangKy = context.PhieuDangKies
                            .Join(context.KhachHangs,
                                    phieuDangKy => phieuDangKy.MaKh,
                                    khachHang => khachHang.MaKh,
                                    (phieuDangKy, khachHang) => new ThongTinPhieuDangKyDTO
                                    {
                                        MaPhieuDangKy = phieuDangKy.MaPhieuDk,
                                        MaKhachHang = khachHang.MaKh,
                                        HoTen = khachHang.HoTen,
                                        NgaySinh = khachHang.NgaySinh,
                                        DiaChi = khachHang.DiaChi,
                                        SoDt = khachHang.SoDt
                                    })
                            .Where(phieuDangKy => phieuDangKy.MaPhieuDangKy == maPhieu);
            return thongTinPhieuDangKy.FirstOrDefault();
        }
        public static bool taoPhieuDKyDB(Models.PhieuDangKy phieu)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            context.PhieuDangKies.Add(phieu);
            context.SaveChanges();
            if (context.KhachHangs.Find(phieu.MaPhieuDk) == null)
            {
                return false;
            }
            return true;
        }
        public static void tinhTongTien(string maphieu)
        {
            
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var tongtien = from ph in context.PhieuDangKies
                           join ct in context.ChiTietDangKies on ph.MaPhieuDk equals ct.MaPhieuDk
                           join vx in context.Vaccines on ct.MaVaccine equals vx.MaVaccine
                           where ph.MaPhieuDk == maphieu
                           group ct by ct.MaPhieuDk into sum
                           select new
                           {
                               //tongtien = sum.Sum(ct.Gia),
                           };
        }
        public static List<Models.PhieuDangKy> loadPhieuDky_KH(string makh)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list = context.PhieuDangKies.Where(c => c.MaKh == makh);
            return list.ToList();
        }
    }
}
