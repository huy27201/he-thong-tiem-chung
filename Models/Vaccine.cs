using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Vaccine
    {
        public Vaccine()
        {
            ChiTietDangKies = new HashSet<ChiTietDangKy>();
            ChiTietPhieuMuas = new HashSet<ChiTietPhieuMua>();
        }

        public string MaVaccine { get; set; }
        public string TenVaccine { get; set; }
        public double? Gia { get; set; }

        public virtual VaccineGoi VaccineGoi { get; set; }
        public virtual VaccineLe VaccineLe { get; set; }
        public virtual ICollection<ChiTietDangKy> ChiTietDangKies { get; set; }
        public virtual ICollection<ChiTietPhieuMua> ChiTietPhieuMuas { get; set; }
    }
}
