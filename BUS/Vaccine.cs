using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;

namespace BUS
{
    public class Vaccine
    {
        public static List<Models.Vaccine> getVaccineBUS()
        {
            var listVaccine = DAO.Vaccine.getVaccineDAO();
            return listVaccine;
        }
    }
}
