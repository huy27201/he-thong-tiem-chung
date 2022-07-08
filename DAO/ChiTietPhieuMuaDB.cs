using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietPhieuMuaDB
    {

        HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<ChiTietPhieuMua> getCTPhieuMuas(string MaPhieuMua)
        {
            var phieumuaList = context.ChiTietPhieuMuas
                .Where(x => x.MaPhieuMua == MaPhieuMua)
                .ToList();
            return phieumuaList;
        }
        public List<ChiTietPhieuMuaDTO> getCTPhieuMuasDTO(string MaPhieuMua)
        {
            var phieumuaList = context.ChiTietPhieuMuas
                .Join(context.Vaccines,
                chitietphieumua => chitietphieumua.MaVaccine,
                vaccine => vaccine.MaVaccine,
                (chitietphieumua,vaccine) => new ChiTietPhieuMuaDTO
                {
                    MaPhieuMua = chitietphieumua.MaPhieuMua,
                    MaVaccine = chitietphieumua.MaVaccine,
                    SoLuong = chitietphieumua.SoLuong,
                    TenVaccine = vaccine.TenVaccine,
                    Gia = vaccine.Gia
                }
                )
                .Where(x => x.MaPhieuMua == MaPhieuMua)
                .ToList();
            return phieumuaList;
        }
        public void addCTPhieuMua(ChiTietPhieuMua ctpm)
        {
            context.ChiTietPhieuMuas.Add(ctpm);
            context.SaveChanges();
        }
        public void deleteCTPhieuMua(Models.ChiTietPhieuMua CTPhieuMua)
        {
            context.ChiTietPhieuMuas.Remove(CTPhieuMua);
        }
    }
}
