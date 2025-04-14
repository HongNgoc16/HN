using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
using static QuanLyVanBangTotNghiep_BTL.DAL.VanBangTam_DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class VanBangTam_BLL
    {
        private VanBangTam_DAL dal = new VanBangTam_DAL();

        // Lấy danh sách văn bằng tạm
        public List<chon_vanbangtam_Result> GetChon_Vanbangtam_Results()
        {
            return dal.GetChon_Vanbangtam_Results();
        }

        // Thêm văn bằng tạm
        public void ThemVanBangTam(string soHieu, int idDotCap, int idSinhVien, DateTime ngayCap, string noiCap)
        {
            // Trạng thái mặc định là "Chờ duyệt" (0)
            dal.ThemVanBangTam(soHieu, idDotCap, idSinhVien, ngayCap, noiCap, trangThai: 0);
        }

        // Sửa văn bằng tạm
        public void SuaVanBangTam(int idVanBang, string soHieu, int idDotCap, int idSinhVien, DateTime ngayCap, string noiCap, int trangThai)
        {
            dal.SuaVanBangTam(idVanBang, soHieu, idDotCap, idSinhVien, ngayCap, noiCap, trangThai);
        }

        // Xóa văn bằng tạm
        public void XoaVanBangTam(int idVanBang)
        {
            dal.XoaVanBangTam(idVanBang);
        }

        // Phương thức để lấy trạng thái dưới dạng chuỗi
        public string GetTrangThaiString(int trangThai)
        {
            switch (trangThai)
            {
                case 0: return "Chờ duyệt";
                case 1: return "Đã duyệt";
                case 2: return "Từ chối";
                default: return "Không xác định";
            }

        }
        public List<timkiem_vanbangtam_Result> TimKiem(string maSV, string tenNganh, string tenChuyenNganh, int? trangThai)
        {
            return dal.TimKiem(maSV, tenNganh, tenChuyenNganh, trangThai);
        }
    }

}
