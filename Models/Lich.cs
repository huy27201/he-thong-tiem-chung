using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Lich
    {
        public string MaNv { get; set; }
        public DateTime Ngay { get; set; }
        public int Ca { get; set; }
        public string LoaiLich { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
