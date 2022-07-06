using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;

namespace BUS
{
    public class VaccineBUS
    {
        public static List<Vaccine> getVaccineBUS()
        {
            var listVaccine = VaccineDAO.getVaccineDAO();
            return listVaccine;
        }
    }
}
