using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class UcNganhHoc : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public UcNganhHoc()
        {
            InitializeComponent();
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaNganh.Clear();
            txtTenNganh.Clear();
            rdoDangSd.Checked = false;
            rdoKhongSd.Checked = false;
            txtMaNganh.Focus();
            opt= 1;    
        }
        public void HienThiDuLieu()
        {
         var danhSach = db.chon_nganhhoc()
        .Select(n => new
        {
            MaNganh = n.Ma_NganhHoc,
            TenNganh = n.Ten_Nganh,
            TrangThai = n.Trang_Thai_Su_Dung.HasValue && n.Trang_Thai_Su_Dung.Value
                         ? "Đang sử dụng"
                         : "Không sử dụng"
        }).ToList();

    dgvNganhHoc.DataSource = danhSach;

    // Đổi tên tiêu đề cột sang tiếng Việt
    dgvNganhHoc.Columns[0].HeaderText = "Mã Ngành";
    dgvNganhHoc.Columns[1].HeaderText = "Tên Ngành";
    dgvNganhHoc.Columns[2].HeaderText = "Trạng Thái";

    // Thiết lập font Times New Roman, không đậm
    dgvNganhHoc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
    dgvNganhHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Regular);
    dgvNganhHoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

    // Căn lề nếu cần
    dgvNganhHoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

    // Tự động giãn cột
    dgvNganhHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
     
       
      
        private void UcNganhHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bool trangThaiSuDung = rdoDangSd.Checked;  // Nếu chọn Đang sử dụng thì true, còn lại là false

            if (opt == 1)  // Nếu là thêm mới
            {
                db.them_nganhhoc(txtMaNganh.Text, txtTenNganh.Text, trangThaiSuDung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Thêm ngành học thành công!");
            }
            else if (opt == 2)  // Nếu là sửa
            {
                int id = Convert.ToInt32(dgvNganhHoc[0, dgvNganhHoc.CurrentRow.Index].Value.ToString());
                db.sua_nganhhoc(id, txtMaNganh.Text, txtTenNganh.Text, trangThaiSuDung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Sửa ngành học thành công!");
            }

        }

        private void DgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Kiểm tra có chọn được dòng không
            {
                txtMaNganh.Text = dgvNganhHoc.Rows[e.RowIndex].Cells[0].Value.ToString();  // Cột 0: Mã Ngành
                txtTenNganh.Text = dgvNganhHoc.Rows[e.RowIndex].Cells[1].Value.ToString();  // Cột 1: Tên Ngành

                string trangThai = dgvNganhHoc.Rows[e.RowIndex].Cells[2].Value.ToString();  // Cột 2: Trạng Thái

                // Nếu trạng thái là "Đang sử dụng", đánh dấu vào radio button Đang sử dụng
                if (trangThai == "Đang sử dụng")
                {
                    rdoDangSd.Checked = true;
                    rdoKhongSd.Checked = false;
                }
                else // Nếu là "Không sử dụng", đánh dấu vào radio button Không sử dụng
                {
                    rdoKhongSd.Checked = true;
                    rdoDangSd.Checked = false;
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNganhHoc.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvNganhHoc[0, dgvNganhHoc.CurrentRow.Index].Value.ToString());

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.xoa_nganhhoc(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa dữ liệu thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngành học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNganhHoc.CurrentRow != null)
            {
                bool trangThaiSuDung = rdoDangSd.Checked;


                int id = Convert.ToInt32(dgvNganhHoc[0, dgvNganhHoc.CurrentRow.Index].Value.ToString());
                db.sua_nganhhoc(id, txtMaNganh.Text, txtTenNganh.Text, trangThaiSuDung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Sửa ngành học thành công!");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string maNganh = txtMaNganh.Text.Trim().ToLower();
            string tenNganh = txtTenNganh.Text.Trim().ToLower();

            // Kiểm tra xem người dùng có muốn lọc theo trạng thái sử dụng không
            bool locTheoTrangThai = rdoDangSd.Checked || rdoKhongSd.Checked;
            bool trangThaiSuDung = rdoDangSd.Checked;

            var ketQua = db.chon_nganhhoc().AsQueryable();

            if (!string.IsNullOrEmpty(maNganh))
            {
                ketQua = ketQua.Where(n => n.Ma_NganhHoc.ToLower().Contains(maNganh));
            }

            if (!string.IsNullOrEmpty(tenNganh))
            {
                ketQua = ketQua.Where(n => n.Ten_Nganh.ToLower().Contains(tenNganh));
            }

            if (locTheoTrangThai)
            {
                ketQua = ketQua.Where(n => n.Trang_Thai_Su_Dung == trangThaiSuDung);
            }

            var danhSach = ketQua.ToList();

            if (danhSach.Any())
            {
                dgvNganhHoc.DataSource = danhSach;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ngành học phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
