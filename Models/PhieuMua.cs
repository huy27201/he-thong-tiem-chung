using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuMua
    {
        public PhieuMua()
        {
            ChiTietPhieuMuas = new HashSet<ChiTietPhieuMua>();
            CtphieuDatHangs = new HashSet<CtphieuDatHang>();
        }

        public string MaPhieuMua { get; set; }
        public string TrangThai { get; set; }
        public string MaKh { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
        public virtual ICollection<CtphieuDatHang> CtphieuDatHangs { get; set; }
    }
}
