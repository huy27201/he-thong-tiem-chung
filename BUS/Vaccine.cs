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
        public VaccineDAO vaccineDAO { get; set; }

        public Vaccine()
        {
            vaccineDAO = new VaccineDAO();
        }
        public List<VaccineDTO> getVaccines()
        {
            var vaccineList = vaccineDAO.getVaccines();
            return vaccineList;
        }
    }
}
