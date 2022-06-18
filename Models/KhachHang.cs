using System;
using System.Collections.Generic;

namespace Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            PhieuMuas = new HashSet<PhieuMua>();
        }

        public string MaKh { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
        public string GiamHo { get; set; }

        public virtual NguoiGiamHo GiamHoNavigation { get; set; }
        public virtual ICollection<PhieuMua> PhieuMuas { get; set; }
    }
}
