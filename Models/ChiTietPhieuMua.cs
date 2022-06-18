using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ChiTietPhieuMua
    {
        public string MaPhieuMua { get; set; }
        public string MaVaccine { get; set; }
        public int? SoLuong { get; set; }

        public virtual PhieuMua MaPhieuMuaNavigation { get; set; }
        public virtual Vaccine MaVaccineNavigation { get; set; }
    }
}
