using System;
using System.Collections.Generic;

namespace Models
{
    public partial class NguoiGiamHo
    {
        public NguoiGiamHo()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public string MaGiamHo { get; set; }
        public string HoTen { get; set; }
        public string MoiQuanHe { get; set; }
        public string SoDt { get; set; }

        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
