using System;
using System.Collections.Generic;

namespace Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            Liches = new HashSet<Lich>();
            PhieuDatHangs = new HashSet<PhieuDatHang>();
            PhieuMuas = new HashSet<PhieuMua>();
        }

        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string BangCap { get; set; }
        public string TrungTamLamViec { get; set; }
        public string ViTri { get; set; }
        public double? Luong { get; set; }

        public virtual ICollection<Lich> Liches { get; set; }
        public virtual ICollection<PhieuDatHang> PhieuDatHangs { get; set; }
        public virtual ICollection<PhieuMua> PhieuMuas { get; set; }
    }
}
