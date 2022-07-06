using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VaccineDB
    {
        HTTiemChungDBContext context = new HTTiemChungDBContext();

        public List<VaccineDTO> getVaccines()
        {
            var vaccineList = context.Vaccines
                .Join(context.VaccineGois,
                vaccine => vaccine.MaVaccine,
                vaccinegoi => vaccinegoi.MaGoiVaccine,
                (vaccine, vaccinegoi) => new VaccineDTO
                {
                    MaVaccine = vaccine.MaVaccine,
                    TenVaccine = vaccine.TenVaccine,
                    Loai = vaccinegoi.Loai,
                    Gia = vaccine.Gia
                }
                );
            return vaccineList.ToList();
        }
    }
}
