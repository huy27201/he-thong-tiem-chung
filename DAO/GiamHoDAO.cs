using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAO
{
    public class GiamHoDAO
    {
        public static bool InsertGiamHoDAO(NguoiGiamHo gh)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            context.NguoiGiamHos.Add(gh);
            context.SaveChanges();
            if (context.KhachHangs.Find(gh.MaGiamHo) != null)
            {
                return false;
            }
            return true;
        }
    }
}
