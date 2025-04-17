using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;
namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class VanBangCT_BLL
    {
        private VanBangCT_DAL dal = new VanBangCT_DAL();

        public List<chon_vanbangchinhthuc_Result> chon_Vanbangchinhthuc_Results()
        {
            return dal.GetChon_Vanbangchinhthuc_Results();
        }
        public void CapNhatTrangThaiVanBang(int idVanBang, int idPhoiBang)
        {
            dal.CapNhatTrangThaiVanBang(idVanBang, idPhoiBang);
        }
        public List<timkiem_vanbangchinhthuc_Result> TraCuuVanBang(string maSinhVien, string hoVaTen, string soHieu)
        {
            return dal.TraCuuVanBang(maSinhVien, hoVaTen, soHieu);
        }
        public List<timkiem_vanbangchinhthuc_Result> TimKiemVanBang(string maSinhVien, string hoVaTen, string tenNganh, string khoaHoc, string xepLoai, int? trangThai)
        {
            // Xử lý chuỗi rỗng thành null
            maSinhVien = string.IsNullOrWhiteSpace(maSinhVien) ? null : maSinhVien;
            hoVaTen = string.IsNullOrWhiteSpace(hoVaTen) ? null : hoVaTen;
            tenNganh = string.IsNullOrWhiteSpace(tenNganh) ? null : tenNganh;
            khoaHoc = string.IsNullOrWhiteSpace(khoaHoc) ? null : khoaHoc;
            xepLoai = string.IsNullOrWhiteSpace(xepLoai) ? null : xepLoai;

            // Gọi DAL để thực hiện tìm kiếm
            var result = dal.TimKiemVanBang(maSinhVien, tenNganh, hoVaTen, null, xepLoai, trangThai);

            // Lọc thêm theo khóa học nếu có
            return result.Where(vb => string.IsNullOrEmpty(khoaHoc) || vb.Ma_KhoaHoc.Contains(khoaHoc)).ToList();
        }
    }
}
