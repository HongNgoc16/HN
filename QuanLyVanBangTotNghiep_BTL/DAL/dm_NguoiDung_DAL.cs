using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class dm_NguoiDung_DAL
    {
        private QLVB_Entities db= new QLVB_Entities();
        public List<chon_nguoidung_Result> GetChon_Nguoidung_Results()
        {
            return db.chon_nguoidung().ToList();
        }
        public void ThemNguoiDung (string maNguoiDung, string tenDangNhap, string matKhau,string loaiNguoiDung)
        {
            db.them_nguoidung(maNguoiDung, tenDangNhap, matKhau, loaiNguoiDung);
        }
        public void SuaNguoiDung (int id, string maNguoiDung, string tenDangNhap, string matKhau, string loaiNguoiDung)
        {
            db.sua_nguoidung(id, maNguoiDung, tenDangNhap, matKhau, loaiNguoiDung);
        }
        public void XoaNguoiDung (int id)
        {
            db.xoa_nguoidung (id);
        }

    }
}
