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
        public static List<string> load_DSVacxinForCBB()
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list =(from a in context.Vaccines select a.MaVaccine).ToList();
            return list;
        }
        public static List<Models.Vaccine> load_DSVX()
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list = context.Vaccines.ToList();
            return list;
        }
        public static List<Models.Vaccine> load_DSVXLe()
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            var list = context.Vaccines
             .Join(context.VaccineLes, vx => vx.MaVaccine, vxl => vxl.MaVaccineLe, (vx, vxl) => new
             {
                 MaVaccine = vx.MaVaccine,
                 TenVaccine = vx.TenVaccine,
                 Gia = vx.Gia
             })
            .Select(x => new Models.Vaccine()
            {
                MaVaccine = x.MaVaccine,
                TenVaccine = x.TenVaccine,
                Gia = x.Gia
            }).ToList();
            return list;
        }
        public static List<Models.Vaccine> load_DSVXGoi()
        {
                HTTiemChungDBContext context = new HTTiemChungDBContext();
                var list = context.Vaccines
                 .Join(context.VaccineGois, vx=> vx.MaVaccine , vxg => vxg.MaGoiVaccine, (vx, vxg) => new
                 {
                     MaVaccine = vx.MaVaccine,
                     TenVaccine = vx.TenVaccine,
                     Gia = vx.Gia
                 })
                .Select(x => new Models.Vaccine()
                {
                    MaVaccine = x.MaVaccine,
                    TenVaccine = x.TenVaccine,
                    Gia = x.Gia
                }).ToList();
                return list;
            
        }
    }
}
