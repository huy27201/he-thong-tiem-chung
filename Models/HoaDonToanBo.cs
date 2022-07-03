using System;
using System.Collections.Generic;

namespace Models
{
    public partial class HoaDonToanBo
    {
        public string MaHoaDonToanBo { get; set; }
        public DateTime? NgayTt { get; set; }
        public string PhieuDk { get; set; }

        public virtual PhieuDangKy PhieuDkNavigation { get; set; }
    }
}
