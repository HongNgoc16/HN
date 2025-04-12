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

            public void ThemVanBang(string soHieu, int idDotCap, int idSinhVien, DateTime ngayCap, string noiCap, bool trangThai = false)
            {
                db.them_vanbang(soHieu, idDotCap, idSinhVien, ngayCap, noiCap, trangThai);
            }
            public void XoaVanBang(int idVanBang)
            {
                db.xoa_vanbang(idVanBang);
            }

        }
    }
}
