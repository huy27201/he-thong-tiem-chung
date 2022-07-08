using DAO;
using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Vaccine
    {
        public VaccineDB vaccineDAO { get; set; }

        public Vaccine()
        {
            vaccineDAO = new VaccineDB();
        }
        public List<VaccineDTO> getVaccines()
        {
            var vaccineList = vaccineDAO.getVaccines();
            return vaccineList;
        }
        public Models.Vaccine getVaccine(string mavc)
        {
            return vaccineDAO.getVaccine(mavc);
        }
    }
}
