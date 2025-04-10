using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class dm_SinhVien_DAL
    {
        private QLVB_Entities db = new QLVB_Entities();

        public List<chon_sinhvien_Result> GetChon_Sinhvien_Results()
        {
            return db.chon_sinhvien().ToList();
        }

        public List<chon_sinhvien_Result> TimKiemSinhVien(string tuKhoa)
        {
            return db.chon_sinhvien()
                     .Where(sv => sv.Ma_SinhVien.Contains(tuKhoa) || sv.Ho_Va_Ten.Contains(tuKhoa))
                     .ToList();
        }

        public void ThemSinhVien(string maSV, string hoTen, bool gioiTinh, DateTime ngaySinh, int idChuyenNganh,
            int idKhoaHoc, string sdt, string email, decimal diemTBTL, int idXepLoai, int idDVQL, bool trangThai)
        {
            db.them_sinhvien(maSV, hoTen, gioiTinh, ngaySinh, idChuyenNganh, idKhoaHoc,
                             sdt, email, diemTBTL, idXepLoai, idDVQL, trangThai);
        }

        public void SuaSinhVien(int id, string maSV, string hoTen, bool gioiTinh, DateTime ngaySinh, int idChuyenNganh,
            int idKhoaHoc, string sdt, string email, decimal diemTBTL, int idXepLoai, int idDVQL, bool trangThai)
        {
            db.sua_sinhvien(id, maSV, hoTen, gioiTinh, ngaySinh, idChuyenNganh, idKhoaHoc,
                            sdt, email, diemTBTL, idXepLoai, idDVQL, trangThai);
        }

        public void XoaSinhVien(int id)
        {
            db.xoa_sinhvien(id);
        }
    }
}
