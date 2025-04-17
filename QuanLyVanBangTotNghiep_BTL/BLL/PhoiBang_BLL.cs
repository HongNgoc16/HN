using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVanBangTotNghiep_BTL.DAL;

namespace QuanLyVanBangTotNghiep_BTL.BLL
{
    public class PhoiBang_BLL
    {
        PhoiBang_DAL dal = new PhoiBang_DAL();

        public List<chon_phoibang_Result> GetChon_Phoibang_Results()
        {
            return dal.GetChon_Phoibang_Results();
        }

        public void ThemPhoiBang(string soHieu, DateTime? ngayNhap, string ghiChu, int trangThai)
        {
            dal.ThemPhoiBang(soHieu, ngayNhap, ghiChu, trangThai);
        }

        public List<chon_phoibang_Result> LayPhoiChuaCap()
        {
            return dal.LayPhoiChuaCap();
        }
        public void CapNhatTrangThaiPhoi(int idPhoiBang)
        {
            dal.CapNhatTrangThaiPhoi(idPhoiBang);
        }

    }

}
