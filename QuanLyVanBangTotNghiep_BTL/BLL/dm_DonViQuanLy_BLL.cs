using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class dm_DonViQuanLy_BLL
    {
        private dm_DonViQuanLy_DAL dal = new dm_DonViQuanLy_DAL();
        public List<chon_donviquanly_Result> GetChon_Donviquanly_Results()
        {
            return dal.GetChon_Donviquanly_Results();
        }
        public void ThemDonViQuanLy (string maDonViQuanLy, string tenDonViQuanLy, string tenDonViQuanLyCha, bool trang_Thai_Su_Dung)
        {
            dal.ThemDonViQuanLy(maDonViQuanLy, tenDonViQuanLy, tenDonViQuanLyCha, trang_Thai_Su_Dung);
        }
        public void SuaDonViQuanLy (int id, string maDonViQuanLy, string tenDonViQuanLy, string tenDonViQuanLyCha, bool trang_Thai_Su_Dung)
        {
            dal.SuaDonViQuanLy(id, maDonViQuanLy, tenDonViQuanLy, tenDonViQuanLyCha, trang_Thai_Su_Dung);
        }
        public void XoaDonViQuanLy(int id)
        {
            dal.XoaDonViQuanLy(id);
        }
       
    }
}
