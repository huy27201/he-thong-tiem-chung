using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuDangKy
    {
        public PhieuDangKy()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaPhieuDk { get; set; }
        public double? TongTien { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayDk { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
