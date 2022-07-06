using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuDangKyDAO
    {
        private static HTTiemChungDBContext context = new HTTiemChungDBContext();

        public static List<PhieuDangKyDTO> loadDSPhieuDangKy()
        {
            var dsphieuDangKy = context.PhieuDangKies
                            .Join(context.KhachHangs,
                                    phieuDangKy => phieuDangKy.MaKh,
                                    khachHang => khachHang.MaKh,
                                    (phieuDangKy, khachHang) => new PhieuDangKyDTO
                                    {
                                        MaPhieuDangKy = phieuDangKy.MaPhieuDk,
                                        HoTen = khachHang.HoTen,
                                        NgayDangKy = phieuDangKy.NgayDk,
                                    });
            return dsphieuDangKy.ToList();
        }
    }
}
