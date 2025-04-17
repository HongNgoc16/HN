using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.DAL
{
    public class PhoiBang_DAL
    {
        QLVB_Entities db = new QLVB_Entities();

        public List<chon_phoibang_Result> GetChon_Phoibang_Results()
        {
            return db.chon_phoibang().ToList();
        }

        public void ThemPhoiBang(string soHieu, DateTime? ngayNhap, string ghiChu, int trangThai)
        {
            db.them_phoibang(soHieu, ngayNhap, ghiChu, trangThai);
        }
        public List<chon_phoibang_Result> LayPhoiChuaCap()
        {
            return db.chon_phoibang().Where(p => p.TrangThai == "Chưa cấp").ToList();
        }
        public void CapNhatTrangThaiPhoi(int idPhoiBang)
        {
            var phoi = db.PhoiBangs.FirstOrDefault(p => p.Id_PhoiBang == idPhoiBang);
            if (phoi != null)
            {
                phoi.TrangThai = 1; // Đã cấp
                db.SaveChanges();
            }
        }
    }
}
