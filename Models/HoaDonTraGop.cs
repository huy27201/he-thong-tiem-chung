using System;
using System.Collections.Generic;

namespace Models
{
    public partial class HoaDonTraGop
    {
        public HoaDonTraGop()
        {
            CttraGops = new HashSet<CttraGop>();
        }

        public string MaHoaDonTraGop { get; set; }
        public int? SoDotThanhToan { get; set; }
        public string PhuongThucTt { get; set; }
        public string PhieuDk { get; set; }

        public virtual PhieuDangKy PhieuDkNavigation { get; set; }
        public virtual ICollection<CttraGop> CttraGops { get; set; }
    }
}
