using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class VanBangCT_DAL
    {
        private QLVB_Entities db = new QLVB_Entities();

        public List<chon_vanbangchinhthuc_Result> GetChon_Vanbangchinhthuc_Results()
        {
            return db.chon_vanbangchinhthuc().ToList();
        }
        public void CapNhatTrangThaiVanBang(int idVanBang, int idPhoiBang)
        {
             var vb = db.VanBangChinhThucs.FirstOrDefault(v => v.Id_VanBang == idVanBang);
             if (vb != null)
                 {
            vb.Trang_Thai = 1; // Đã cấp
            vb.Id_PhoiBang = idPhoiBang;
            vb.Ngay_Cap = DateTime.Now; // nếu muốn cập nhật ngày cấp luôn
            db.SaveChanges();
        }

    }

        public List<timkiem_vanbangchinhthuc_Result> TraCuuVanBang(string maSinhVien, string hoVaTen, string soHieu)
        {
            return db.timkiem_vanbangchinhthuc(maSinhVien, null, null, null, hoVaTen, null, soHieu, null).ToList();
        }

        public List<timkiem_vanbangchinhthuc_Result> TimKiemVanBang(string maSinhVien, string tenNganh, string hoVaTen, string soHieu, string xepLoai, int? trangThai)
        {
            return db.timkiem_vanbangchinhthuc(maSinhVien, tenNganh, null, trangThai, hoVaTen, null, soHieu, xepLoai).ToList();
        }
    }

}
