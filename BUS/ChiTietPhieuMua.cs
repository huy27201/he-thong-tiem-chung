using System;
using Models;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ChiTietPhieuMua
    {
        ChiTietPhieuMuaDB ctpmDAO = new ChiTietPhieuMuaDB();
        public List<Models.ChiTietPhieuMua> getCTPhieuMuas(string MaPhieuMua)
        {
            return ctpmDAO.getCTPhieuMuas(MaPhieuMua);
        }
        public List<ChiTietPhieuMuaDTO> getCTPhieuMuasDTO(string MaPhieuMua)
        {
            return ctpmDAO.getCTPhieuMuasDTO(MaPhieuMua);
        }
        public void addCTPhieuMua(Models.ChiTietPhieuMua ctpm)
        {
            ctpmDAO.addCTPhieuMua(ctpm);
        }
        public void addListCTPhieuMua(List<ChiTietPhieuMuaDTO> listCTPM)
        {
            foreach (var ctpm in listCTPM)
            {

                ctpmDAO.addCTPhieuMua(
                    new Models.ChiTietPhieuMua()
                    {
                        MaPhieuMua = ctpm.MaPhieuMua,
                        MaVaccine = ctpm.MaVaccine,
                        SoLuong = ctpm.SoLuong
                    }
                    );
            }    
        }
        public void deleteListCTPhieuMua(string maPhieuMua)
        {
            List<Models.ChiTietPhieuMua> listCTPhieuMua = ctpmDAO.getCTPhieuMuas(maPhieuMua);
            foreach (var ctpm in listCTPhieuMua)
            {
                ctpmDAO.deleteCTPhieuMua(ctpm);
            }
        }
    }
}
