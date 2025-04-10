using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
using static QuanLyVanBangTotNghiep_BTL.DAL.VanBang_DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class VanBang_BLL
    {
        private dm_VanBang_DAL dal = new dm_VanBang_DAL();

        public List<chon_vanbang_Result> GetChon_Vanbang_Results()
        {
            return dal.GetChon_Vanbang_Results();
        }
    }
}
