using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PhieuDatHang
    {
        public PhieuDatHang()
        {
            CtphieuDatHangs = new HashSet<CtphieuDatHang>();
        }

        public string MaPhieuDatHang { get; set; }
        public string Nvduyet { get; set; }

        public virtual NhanVien NvduyetNavigation { get; set; }
        public virtual ICollection<CtphieuDatHang> CtphieuDatHangs { get; set; }
    }
}
