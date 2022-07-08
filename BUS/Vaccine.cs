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
        public Vaccine vaccineDAO { get; set; }

        public Vaccine()
        {
            vaccineDAO = new Vaccine();
        }
        public List<VaccineDTO> getVaccines()
        {
            var vaccineList = vaccineDAO.getVaccines();
            return vaccineList;
        }
        public static List<string> DKy_LoadVacxin()
        {
            List<string> vaccineList = new List<string>();
            vaccineList = VaccineDB.load_DSVacxinForCBB();
            return vaccineList;
        }
        public static List<Models.Vaccine> loadVacxin()
        {
            return DAO.VaccineDB.load_DSVX();
        }
        public static List<Models.Vaccine> loadVacxinLe()
        {
            return DAO.VaccineDB.load_DSVXLe();
        }
        public static List<Models.Vaccine> loadVacxinGoi()
        {
            return DAO.VaccineDB.load_DSVXGoi();
        }
    }
}
