using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class LayThongTin_DAL
    {
        QLVB_Entities db = new QLVB_Entities();
        public lay_thong_tin_sinhvien_Result LayThongTinTheoMaSV(string maSV)
        {
           
                return db.lay_thong_tin_sinhvien(maSV).FirstOrDefault();
            }
        }

    
}
