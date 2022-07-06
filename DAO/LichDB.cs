using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichDB
    {
        private static HTTiemChungDBContext context = new HTTiemChungDBContext();
        public static List<Lich> LayLichLamViec(String MaNV)
        {
            return context.Liches.Where(x => x.MaNv == MaNV && x.LoaiLich == "Lịch làm việc").ToList();
        }
        public static List<Lich> LayLichRanh(String MaNV)
        {
            return context.Liches.Where(x => x.MaNv == MaNV && x.LoaiLich == "Lịch rảnh").ToList();
        }
        public static void ThemLich(Lich lich)
        {
            context.Liches.Add(lich);
            context.SaveChanges();
        }
    }
}
