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
    public partial class ucNganhHoc : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public ucNganhHoc()
        {
            InitializeComponent();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaNganh.Clear();
            textTenNganh.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            textMaNganh.Focus();
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

    dgNganhHoc.DataSource = danhSach;

    // Đổi tên tiêu đề cột sang tiếng Việt
    dgNganhHoc.Columns[0].HeaderText = "Mã Ngành";
    dgNganhHoc.Columns[1].HeaderText = "Tên Ngành";
    dgNganhHoc.Columns[2].HeaderText = "Trạng Thái";

    // Thiết lập font Times New Roman, không đậm
    dgNganhHoc.Font = new Font("Times New Roman", 11, FontStyle.Regular);
    dgNganhHoc.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Regular);
    dgNganhHoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

    // Căn lề nếu cần
    dgNganhHoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

    // Tự động giãn cột
    dgNganhHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
     
       
      
        private void ucNganhHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;  // Nếu chọn Đang sử dụng thì true, còn lại là false

            if (opt == 1)  // Nếu là thêm mới
            {
                db.them_nganhhoc(textMaNganh.Text, textTenNganh.Text, trang_Thai_Su_Dung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Thêm ngành học thành công!");
            }
            else if (opt == 2)  // Nếu là sửa
            {
                int id = Convert.ToInt32(dgNganhHoc[0, dgNganhHoc.CurrentRow.Index].Value.ToString());
                db.sua_nganhhoc(id, textMaNganh.Text, textTenNganh.Text, trang_Thai_Su_Dung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Sửa ngành học thành công!");
            }

        }

        private void dgNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Kiểm tra có chọn được dòng không
            {
                textMaNganh.Text = dgNganhHoc.Rows[e.RowIndex].Cells[0].Value.ToString();  // Cột 0: Mã Ngành
                textTenNganh.Text = dgNganhHoc.Rows[e.RowIndex].Cells[1].Value.ToString();  // Cột 1: Tên Ngành

                string trangThai = dgNganhHoc.Rows[e.RowIndex].Cells[2].Value.ToString();  // Cột 2: Trạng Thái

                // Nếu trạng thái là "Đang sử dụng", đánh dấu vào radio button Đang sử dụng
                if (trangThai == "Đang sử dụng")
                {
                    rdbDangSd.Checked = true;
                    rdbKhongSd.Checked = false;
                }
                else // Nếu là "Không sử dụng", đánh dấu vào radio button Không sử dụng
                {
                    rdbKhongSd.Checked = true;
                    rdbDangSd.Checked = false;
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgNganhHoc.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgNganhHoc[0, dgNganhHoc.CurrentRow.Index].Value.ToString());

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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgNganhHoc.CurrentRow != null)
            {
                bool trang_Thai_Su_Dung = rdbDangSd.Checked;


                int id = Convert.ToInt32(dgNganhHoc[0, dgNganhHoc.CurrentRow.Index].Value.ToString());
                db.sua_nganhhoc(id, textMaNganh.Text, textTenNganh.Text, trang_Thai_Su_Dung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Sửa ngành học thành công!");
            }
        }

        private void buttonNganhHoc_Click(object sender, EventArgs e)
        {
            string maNganh = textMaNganh.Text.Trim().ToLower();
            string tenNganh = textTenNganh.Text.Trim().ToLower();

            // Kiểm tra xem người dùng có muốn lọc theo trạng thái sử dụng không
            bool locTheoTrangThai = rdbDangSd.Checked || rdbKhongSd.Checked;
            bool trangThaiSuDung = rdbDangSd.Checked;

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
                dgNganhHoc.DataSource = danhSach;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ngành học phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
