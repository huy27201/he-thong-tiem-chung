using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class Vaccine
    {
        public static List<Models.Vaccine> getVaccineDAO()
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var customerList = context.Vaccines.ToList();
            return customerList;
        }
    }
}
