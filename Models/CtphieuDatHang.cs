using System;
using System.Collections.Generic;

namespace Models
{
    public partial class CtphieuDatHang
    {
        public string MaPhieuDh { get; set; }
        public string MaPhieuMua { get; set; }

        public virtual PhieuMua MaPhieuDh1 { get; set; }
        public virtual PhieuDatHang MaPhieuDhNavigation { get; set; }
    }
}
