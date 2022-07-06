using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;

namespace BUS
{
    public class GiamHoBUS
    {
        public static string createGiamHoBUS(NguoiGiamHo GH)
        {
            HTTiemChungDBContext context = new HTTiemChungDBContext();
            int count = context.NguoiGiamHos.ToList().Count();
            string magh = string.Concat("ID0", count.ToString());
            GH.MaGiamHo = magh;
            if (GiamHoDAO.InsertGiamHoDAO(GH))
            {
                return magh;
            }
            return null;
        }
    }
}
