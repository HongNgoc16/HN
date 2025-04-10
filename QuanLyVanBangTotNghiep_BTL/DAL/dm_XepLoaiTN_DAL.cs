using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class dm_XepLoaiTN_DAL
    {
        QLVB_Entities db = new QLVB_Entities();
        public List<chon_xeploai_Result> GetChon_Xeploai_Results()
        {
            return db.chon_xeploai().ToList();
        }
        public void ThemXepLoai(string maXepLoai, string tenXepLoai, decimal diemToiThieu, decimal diemToiDa, bool trang_Thai_Su_Dung)
        {
            db.them_xeploai(maXepLoai, tenXepLoai, diemToiThieu, diemToiDa, trang_Thai_Su_Dung);
        }

        public void SuaXepLoai(int id, string maXepLoai, string tenXepLoai, decimal diemToiThieu, decimal diemToiDa, bool trang_Thai_Su_Dung)
        {
            db.sua_xeploai(id, maXepLoai, tenXepLoai, diemToiThieu, diemToiDa, trang_Thai_Su_Dung);
        }

        public void XoaXepLoai(int id)
        {
            db.xoa_xeploai(id);
        }
    }
}
