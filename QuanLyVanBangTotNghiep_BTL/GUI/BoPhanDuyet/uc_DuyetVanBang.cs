using QuanLyVanBangTotNghiep_BTL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL.BLL;
using QuanLyVanBangTotNghiep_BTL.DAL;
using QuanLyVanBangTotNghiep_BTL.GUI.BoPhanDuyet;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class uc_DuyetVanBang : UserControl
    {
        VanBangTam_BLL vbtam = new VanBangTam_BLL();
        public uc_DuyetVanBang()
        {
            InitializeComponent();
        }
       
        private void LoadDanhSachVanBang()
        {
            var danhSach = vbtam.GetChon_Vanbangtam_Results(); // Viết hàm BLL gọi SP lấy vanbangtam
            dgDuyet.DataSource = danhSach;
        }

      

        private void uc_DuyetVanBang_Load(object sender, EventArgs e)
        {
            cboBoxTrangThai.Items.AddRange(new string[] { "Tất cả", "Chờ duyệt", "Đã duyệt", "Từ chối" });
            cboBoxTrangThai.SelectedIndex = 0;
            LoadDanhSachVanBang();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = textMaSV.Text.Trim();
            string hoTen = textHoVaTen.Text.Trim(); // nếu cần lọc theo họ tên
            string nganhHoc = textNganhHoc.Text.Trim();
            string khoaHoc = textKhoaHoc.Text.Trim();
            int? trangThai = null;

            if (cboBoxTrangThai.SelectedIndex > 0)
            {
                trangThai = cboBoxTrangThai.SelectedIndex - 1; // Giả sử cboTrangThai: 0 - Tất cả, 1 - Chờ duyệt, 2 - Đã duyệt, 3 - Từ chối
            }

            // Gọi hàm tìm kiếm
            var ketQua = vbtam.TimKiem(maSV, nganhHoc, "", trangThai);

            // Nếu có lọc theo tên sinh viên hoặc khóa học, lọc thêm tại đây:
            if (!string.IsNullOrEmpty(hoTen))
                ketQua = ketQua.Where(x => x.Ho_Va_Ten.Contains(hoTen)).ToList();

            if (!string.IsNullOrEmpty(khoaHoc))
                ketQua = ketQua.Where(x => x.Ma_KhoaHoc.Contains(khoaHoc)).ToList();

            // Hiển thị lên DataGridView
            dgDuyet.DataSource = ketQua;
        }

        private void dgDuyet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
            }
        }
    }
}
