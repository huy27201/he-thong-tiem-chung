using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuDangKy
    {
        public PhieuDangKy()
        {
            HoaDonToanBos = new HashSet<HoaDonToanBo>();
            HoaDonTraGops = new HashSet<HoaDonTraGop>();
        }

        public string MaPhieuDk { get; set; }
        public double? TongTien { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayDk { get; set; }

        public virtual ICollection<HoaDonToanBo> HoaDonToanBos { get; set; }
        public virtual ICollection<HoaDonTraGop> HoaDonTraGops { get; set; }
    }
}
