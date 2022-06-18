using System;
using System.Collections.Generic;

namespace Models
{
    public partial class HoaDonTraGop
    {
        public string MaHoaDonTraGop { get; set; }
        public int? DotThanhToan { get; set; }
        public string SoTienThanhToanTungDot { get; set; }

        public virtual HoaDon MaHoaDonTraGopNavigation { get; set; }
    }
}
