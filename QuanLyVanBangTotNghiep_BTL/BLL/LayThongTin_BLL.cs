using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class LayThongTin_BLL
    {
        LayThongTin_DAL dal = new LayThongTin_DAL();

        public lay_thong_tin_sinhvien_Result LayThongTinTheoMaSV(string maSV)
        {
            return dal.LayThongTinTheoMaSV(maSV);
        }
    }
}
