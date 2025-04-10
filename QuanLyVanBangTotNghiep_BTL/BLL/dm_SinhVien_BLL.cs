using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;

namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class dm_SinhVien_BLL
    {
        private dm_SinhVien_DAL dal = new dm_SinhVien_DAL();

        public List<chon_sinhvien_Result> GetChon_Sinhvien_Results()
        {
            return dal.GetChon_Sinhvien_Results();
        }

        public void ThemSinhVien(string maSV, string hoTen, bool gioiTinh, DateTime ngaySinh,
            int idChuyenNganh, int idKhoaHoc, string sdt, string email, decimal diemTBTL,
            int idXepLoai, int idDonVi, bool trangThai)
        {
            dal.ThemSinhVien(maSV, hoTen, gioiTinh, ngaySinh, idChuyenNganh, idKhoaHoc, sdt, email, diemTBTL, idXepLoai, idDonVi, trangThai);
        }

        public void SuaSinhVien(int id, string maSV, string hoTen, bool gioiTinh, DateTime ngaySinh,
            int idChuyenNganh, int idKhoaHoc, string sdt, string email, decimal diemTBTL,
            int idXepLoai, int idDonVi, bool trangThai)
        {
            dal.SuaSinhVien(id, maSV, hoTen, gioiTinh, ngaySinh, idChuyenNganh, idKhoaHoc, sdt, email, diemTBTL, idXepLoai, idDonVi, trangThai);
        }

        public void XoaSinhVien(int id)
        {
            dal.XoaSinhVien(id);
        }
    }
}
