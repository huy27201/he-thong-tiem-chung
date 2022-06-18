using System;
using System.Collections.Generic;

namespace Models
{
    public partial class VaccineGoi
    {
        public VaccineGoi()
        {
            MaVaccineLes = new HashSet<VaccineLe>();
        }

        public string MaGoiVaccine { get; set; }
        public string Loai { get; set; }

        public virtual ICollection<VaccineLe> MaVaccineLes { get; set; }
    }
}
