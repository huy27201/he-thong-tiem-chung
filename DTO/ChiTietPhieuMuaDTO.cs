using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuMuaDTO
    {
        public string MaPhieuMua { get; set; }
        public string MaVaccine { get; set; }
        public int? SoLuong { get; set; }
        public string TenVaccine { get; set; }
        public double? Gia { get; set; }
        public string Loai { get; set; }
    }
}
