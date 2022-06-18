using System;
using System.Collections.Generic;

namespace Models
{
    public partial class ChiTietDangKy
    {
        public string MaPhieuDk { get; set; }
        public string MaVaccine { get; set; }
        public DateTime? ThoiGianTiem { get; set; }
        public string DiaDiem { get; set; }

        public virtual Vaccine MaVaccineNavigation { get; set; }
    }
}
