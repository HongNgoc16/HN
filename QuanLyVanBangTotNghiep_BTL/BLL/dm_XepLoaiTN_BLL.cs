using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;

namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class dm_XepLoaiTN_BLL
    {
        private dm_XepLoaiTN_DAL dal = new dm_XepLoaiTN_DAL();

        public List<chon_xeploai_Result> GetChon_Xeploai_Results()
        {
            return dal.GetChon_Xeploai_Results();
        }

        public void ThemXepLoai(string maXepLoai, string tenXepLoai, decimal diemToiThieu, decimal diemToiDa, bool trang_Thai_Su_Dung)
        {
            dal.ThemXepLoai(maXepLoai, tenXepLoai, diemToiThieu, diemToiDa, trang_Thai_Su_Dung);
        }

        public void SuaXepLoai(int id, string maXepLoai, string tenXepLoai, decimal diemToiThieu, decimal diemToiDa, bool trang_Thai_Su_Dung)
        {
            dal.SuaXepLoai(id, maXepLoai, tenXepLoai, diemToiThieu, diemToiDa, trang_Thai_Su_Dung);
        }

        public void XoaXepLoai(int id)
        {
            dal.XoaXepLoai(id);
        }
    }
}
