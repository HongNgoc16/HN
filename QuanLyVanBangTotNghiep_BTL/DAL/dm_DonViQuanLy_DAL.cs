using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class dm_DonViQuanLy_DAL
    {
        private QLVB_Entities db = new QLVB_Entities();
        public List<chon_donviquanly_Result> GetChon_Donviquanly_Results()
        {
            return db.chon_donviquanly().ToList();  
        }
        public void ThemDonViQuanLy (string maDonViQuanLy, string tenDonViQuanLy, string tenDonViQuanLyCha, bool trang_Thai_Su_Dung)
        {
            db.them_donviquanly(maDonViQuanLy, tenDonViQuanLy, tenDonViQuanLyCha, trang_Thai_Su_Dung);
        }
        public void SuaDonViQuanLy (int id, string maDonViQuanLy, string tenDonViQuanLy, string tenDonViQuanLyCha, bool trang_Thai_Su_Dung)
        {
            db.sua_donviquanly(id, maDonViQuanLy, tenDonViQuanLy, tenDonViQuanLyCha, trang_Thai_Su_Dung);
        }
        public void XoaDonViQuanLy (int id)
        {
            db.xoa_donviquanly(id);
        }
        
    }
}
