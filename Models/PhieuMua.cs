using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuMua
    {
        public PhieuMua()
        {
            ChiTietPhieuMuas = new HashSet<ChiTietPhieuMua>();
            PhieuDatHangs = new HashSet<PhieuDatHang>();
        }

        public string MaPhieuMua { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }
        public string TrangThai { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
        public virtual ICollection<PhieuDatHang> PhieuDatHangs { get; set; }
    }
}
