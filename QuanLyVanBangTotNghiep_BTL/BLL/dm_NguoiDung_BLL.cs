using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using QuanLyVanBangTotNghiep_BTL.DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class dm_NguoiDung_BLL
    {
        private dm_NguoiDung_DAL dal = new dm_NguoiDung_DAL();
        public List<chon_nguoidung_Result> GetChon_Nguoidung_Results()
        {
            return dal.GetChon_Nguoidung_Results();
        }
        public void ThemNguoiDung (string maNguoiDung, string tenDangNhap, string matKhau, string loaiNguoiDung)
        {
            dal.ThemNguoiDung(maNguoiDung, tenDangNhap, matKhau, loaiNguoiDung);
        }
        public void SuaNguoiDung (int id, string maNguoiDung, string tenDangNhap, string matKhau, string loaiNguoiDung)
        {
            dal.SuaNguoiDung(id, maNguoiDung, tenDangNhap, matKhau, loaiNguoiDung); 
        }
        public void XoaNguoiDung (int id)
        {
            dal.XoaNguoiDung(id);
        }
    }
}
