using System;
using System.Collections.Generic;

namespace Models
{
    public partial class HoaDon
    {
        public string MaHd { get; set; }
        public string HinhThuc { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string PhieuDk { get; set; }

        public virtual PhieuDangKy PhieuDkNavigation { get; set; }
        public virtual HoaDonToanBo HoaDonToanBo { get; set; }
        public virtual HoaDonTraGop HoaDonTraGop { get; set; }
    }
}
