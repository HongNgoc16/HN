using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class DotCap_DAL
    {
        private QLVB_Entities db = new QLVB_Entities();

        public List<chon_dot_cap_Result> GetChon_Dot_Cap_Results()
        {
            return db.chon_dot_cap().ToList();
        }

        public void ThemDotCap(string tenDotCap)
        {
            db.them_dot_cap(tenDotCap); // procedure tự tạo
        }

        public void SuaDotCap(int id, string tenDotCap)
        {
            db.sua_dot_cap(id, tenDotCap); // procedure tự tạo
        }

        public void XoaDotCap(int id)
        {
            db.xoa_dot_cap(id);
        }
    }

}
