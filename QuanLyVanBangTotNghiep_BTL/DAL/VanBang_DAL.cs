using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class VanBang_DAL
    {
        public class dm_VanBang_DAL
        {
            private QLVB_Entities db = new QLVB_Entities();

            public List<chon_vanbang_Result> GetChon_Vanbang_Results()
            {
                return db.chon_vanbang().ToList();
            }
        }
    }
}
