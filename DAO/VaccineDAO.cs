using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VaccineDAO
    {
        HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<Vaccine> getVaccines()
        {
            var vaccineList = context.Vaccines.ToList();
            return vaccineList;
        }
    }
}
