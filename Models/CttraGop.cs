using System;
using System.Collections.Generic;

namespace Models
{
    public partial class CttraGop
    {
        public string MaHd { get; set; }
        public int DotThanhToan { get; set; }
        public int? SoTien { get; set; }
        public DateTime? NgayThanhToan { get; set; }

        public virtual HoaDonTraGop MaHdNavigation { get; set; }
    }
}
