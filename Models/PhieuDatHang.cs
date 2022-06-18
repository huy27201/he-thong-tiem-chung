using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuDatHang
    {
        public string MaPhieuDatHang { get; set; }
        public string HoTen { get; set; }
        public string Nvduyet { get; set; }
        public string MaPhieuMua { get; set; }

        public virtual PhieuMua MaPhieuMuaNavigation { get; set; }
        public virtual NhanVien NvduyetNavigation { get; set; }
    }
}
