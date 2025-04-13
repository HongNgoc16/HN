using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class VanBangTam_DAL
    {
        private QLVB_Entities db = new QLVB_Entities();

        // Lấy danh sách văn bằng tạm
        public List<chon_vanbangtam_Result> GetChon_Vanbangtam_Results()
        {
            return db.chon_vanbangtam().ToList();
        }

        // Thêm văn bằng tạm
        public void ThemVanBangTam(string soHieu, int idDotCap, int idSinhVien, DateTime ngayCap, string noiCap, int trangThai = 0)
        {
            db.them_vanbangtam(soHieu, idDotCap, idSinhVien, ngayCap, noiCap, trangThai);
        }

        // Sửa văn bằng tạm
        public void SuaVanBangTam(int idVanBang, string soHieu, int idDotCap, int idSinhVien, DateTime ngayCap, string noiCap, int trangThai)
        {
            db.sua_vanbangtam(idVanBang, soHieu, idDotCap, idSinhVien, ngayCap, noiCap, trangThai);
        }

        // Xóa văn bằng tạm
        public void XoaVanBangTam(int idVanBang)
        {
            db.xoa_vanbangtam(idVanBang);
        }


    }
}

