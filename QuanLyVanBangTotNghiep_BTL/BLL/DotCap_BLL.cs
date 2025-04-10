using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class DotCap_BLL
    {
        private DotCap_DAL dal = new DotCap_DAL();

        public List<chon_dot_cap_Result> GetChon_Dot_Cap_Results()
        {
            return dal.GetChon_Dot_Cap_Results();
        }

        public void ThemDotCap(string tenDotCap)
        {
            dal.ThemDotCap(tenDotCap);
        }

        public void SuaDotCap(int id, string tenDotCap)
        {
            dal.SuaDotCap(id, tenDotCap);
        }

        public void XoaDotCap(int id)
        {
            dal.XoaDotCap(id);
        }
    }
}
