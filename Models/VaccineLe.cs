using System;
using System.Collections.Generic;

namespace Models
{
    public partial class VaccineLe
    {
        public VaccineLe()
        {
            MaGoiVaccines = new HashSet<VaccineGoi>();
        }

        public string MaVaccineLe { get; set; }
        public int? SoLuong { get; set; }

        public virtual ICollection<VaccineGoi> MaGoiVaccines { get; set; }
    }
}
