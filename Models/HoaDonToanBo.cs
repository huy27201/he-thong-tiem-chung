using System;
using System.Collections.Generic;

namespace Models
{
    public partial class HoaDonToanBo
    {
        public string MaHoaDonToanBo { get; set; }

        public virtual HoaDon MaHoaDonToanBoNavigation { get; set; }
    }
}
