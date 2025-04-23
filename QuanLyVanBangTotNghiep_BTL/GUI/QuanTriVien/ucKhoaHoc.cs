using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class UcKhoaHoc : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public UcKhoaHoc()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgvKhoaHoc.DataSource = db.chon_khoahoc();
        }

        private void UcKhoaHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoaHoc.Clear();
            mtxtNamBatDau.Clear();
            mtxtNamKetThuc.Clear();
            rdoChuaTotNghiep.Checked = false;
            rdoDaTotNghiep.Checked = false;
            txtMaKhoaHoc.Focus();
           
            opt = 1;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            
            string namBatDauStr = mtxtNamBatDau.Text.Trim();
            string namKetThucStr = mtxtNamKetThuc.Text.Trim();

            
            if (namBatDauStr.Length != 4 || namKetThucStr.Length != 4)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ năm bắt đầu và năm kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namBatDau, namKetThuc;
            if (!int.TryParse(namBatDauStr, out namBatDau) || !int.TryParse(namKetThucStr, out namKetThuc))
            {
                MessageBox.Show("Năm nhập vào không hợp lệ! Hãy nhập số từ 1900 đến năm hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            int namHienTai = DateTime.Now.Year;
            if (namBatDau < 1900 || namBatDau > namHienTai)
            {
                MessageBox.Show("Năm bắt đầu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (namKetThuc <= namBatDau)
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool trangThai = rdoDaTotNghiep.Checked;

            if (opt == 1) 
            {
                db.them_khoahoc(txtMaKhoaHoc.Text, namBatDau, namKetThuc, trangThai);
                MessageBox.Show("Thêm khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
           
            
            opt = -1;
            HienThiDuLieu();

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoaHoc.CurrentRow == null || dgvKhoaHoc.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một khóa học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvKhoaHoc[0, dgvKhoaHoc.CurrentRow.Index].Value);

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khóa học này không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                db.xoa_khoahoc(id);
                MessageBox.Show("Xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiDuLieu();
            }
        }

        private void DgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhoaHoc.Text = dgvKhoaHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                mtxtNamBatDau.Text = dgvKhoaHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                mtxtNamKetThuc.Text = dgvKhoaHoc.Rows[e.RowIndex].Cells[3].Value.ToString();

                bool trangThai = Convert.ToBoolean(dgvKhoaHoc.Rows[e.RowIndex].Cells[4].Value);
                rdoDaTotNghiep.Checked = trangThai;
                rdoChuaTotNghiep.Checked = !trangThai;
            }
        }

      

        private void BtnSua_Click(object sender, EventArgs e)

        {
            if (dgvKhoaHoc.CurrentRow == null || dgvKhoaHoc.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namBatDauStr = mtxtNamBatDau.Text.Trim();
            string namKetThucStr = mtxtNamKetThuc.Text.Trim();

            if (namBatDauStr.Length != 4 || namKetThucStr.Length != 4)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ năm bắt đầu và năm kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namBatDau, namKetThuc;
            if (!int.TryParse(namBatDauStr, out namBatDau) || !int.TryParse(namKetThucStr, out namKetThuc))
            {
                MessageBox.Show("Năm nhập vào không hợp lệ! Hãy nhập số từ 1900 đến năm hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int namHienTai = DateTime.Now.Year;
            if (namBatDau < 1900 || namBatDau > namHienTai)
            {
                MessageBox.Show("Năm bắt đầu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (namKetThuc <= namBatDau)
            {
                MessageBox.Show("Năm kết thúc phải lớn hơn năm bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool trangThai = rdoDaTotNghiep.Checked;

            int id = Convert.ToInt32(dgvKhoaHoc[0, dgvKhoaHoc.CurrentRow.Index].Value);
            db.sua_khoahoc(id, txtMaKhoaHoc.Text, namBatDau, namKetThuc, trangThai);
            MessageBox.Show("Sửa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiDuLieu();

        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string maKhoaHoc = txtMaKhoaHoc.Text.Trim();
            string namBatDauText = mtxtNamBatDau.Text.Trim();
            string namKetThucText = mtxtNamKetThuc.Text.Trim();

            int namBatDau, namKetThuc;
            bool isNamBatDauValid = int.TryParse(namBatDauText, out namBatDau);
            bool isNamKetThucValid = int.TryParse(namKetThucText, out namKetThuc);

            if (string.IsNullOrEmpty(maKhoaHoc) && !isNamBatDauValid && !isNamKetThucValid)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var danhSachKetQua = db.chon_khoahoc()
                .Where(kh =>
                    (string.IsNullOrEmpty(maKhoaHoc) || kh.Ma_KhoaHoc.Contains(maKhoaHoc)) &&
                    (!isNamBatDauValid || kh.Nam_Bat_Dau == namBatDau) &&
                    (!isNamKetThucValid || kh.Nam_Ket_Thuc == namKetThuc))
                .ToList();

            if (danhSachKetQua.Count > 0)
            {
                dgvKhoaHoc.DataSource = danhSachKetQua;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
           
        
    }
}
