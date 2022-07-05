using DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class VaccineBUS
    {
        public VaccineDAO vaccineDAO { get; set; }

        public VaccineBUS()
        {
            vaccineDAO = new VaccineDAO();
        }
        public List<Vaccine> getVaccines()
        {
            var vaccineList = vaccineDAO.getVaccines();
            return vaccineList;
        }
    }
}
