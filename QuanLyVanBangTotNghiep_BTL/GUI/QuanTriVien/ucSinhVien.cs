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
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucSinhVien : UserControl
    {
        QLVB_Entities db = new QLVB_Entities();
        private dm_SinhVien_BLL bll = new dm_SinhVien_BLL();
        int opt = -1;
        public ucSinhVien()
        {
            InitializeComponent();
        }
        private void LoadComboboxes()
        {
            cboChuyenNganh.DataSource = db.dm_ChuyenNganh.Where(c => c.Trang_Thai_Su_Dung == true).ToList();
            cboChuyenNganh.DisplayMember = "Ten_ChuyenNganh";
            cboChuyenNganh.ValueMember = "Id_ChuyenNganh";

            cboNamTotNghiep.DataSource = db.dm_KhoaHoc.Where(k => k.Trang_Thai == true).ToList();
            cboNamTotNghiep.DisplayMember = "Nam_Ket_Thuc";
            cboNamTotNghiep.ValueMember = "Id_KhoaHoc";

            cboDVQL.DataSource = db.dm_DonViQuanLy.Where(d => d.Trang_Thai_Su_Dung == true).ToList();
            cboDVQL.DisplayMember = "Ten_DonViQuanLy";
            cboDVQL.ValueMember = "Id_DonViQuanLy";

            cboXepLoai.DataSource = db.dm_XepLoai.Where(x => x.Trang_Thai_Su_Dung == true).ToList();
            cboXepLoai.DisplayMember = "Ten_XepLoai"; 
            cboXepLoai.ValueMember = "Id_XepLoai";
        }
            private void HienThiDuLieu()
        {
            dgvSinhVien.DataSource = bll.GetChon_Sinhvien_Results();
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoVaTen.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cboChuyenNganh.SelectedIndex = -1;
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiemTB.Clear();
            cboNamTotNghiep.SelectedIndex = -1;
            cboDVQL.SelectedIndex = -1;
            cboXepLoai.SelectedIndex = -1;
            rdoDaTN.Checked = false;
            rdoChuaTN.Checked = false;
            txtMaSV.Focus();   
            opt = 1; 
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LoadComboboxes();
        }
        private bool ValidateInput()
        {
            // Validate Mã sinh viên
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return false;
            }

            // Validate Họ và tên
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return false;
            }

            // Validate Giới tính (sửa lại tên RadioButton)
            if (!rdoNam.Checked && !rdoNu.Checked) // Đổi từ radioButtonDaTN sang radioButtonNam/Nu
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Chuyên ngành
            if (cboChuyenNganh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboChuyenNganh.Focus();
                return false;
            }

            // Validate Khóa học
            if (cboNamTotNghiep.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamTotNghiep.Focus();
                return false;
            }

            // Validate Số điện thoại
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate Điểm trung bình
            if (!decimal.TryParse(txtDiemTB.Text, out decimal diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải từ 0.00 đến 10.00!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTB.Focus();
                return false;
            }

            // Validate Xếp loại
            if (cboXepLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn xếp loại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboXepLoai.Focus();
                return false;
            }

            // Validate Đơn vị quản lý
            if (cboDVQL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị quản lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDVQL.Focus();
                return false;
            }

            // Validate Trạng thái (sửa lại tên RadioButton)
            if (!rdoDaTN.Checked && !rdoChuaTN.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái tốt nghiệp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




        private void BtnLuu_Click(object sender, EventArgs e)
        {
            {
                if (!ValidateInput()) return;

                try
                {
                    bool gioiTinh = rdoNu.Checked;
                    bool trangThai = rdoDaTN.Checked;
                    decimal diemTB = decimal.Parse(txtDiemTB.Text);

                    if (opt == 1) // Thêm mới
                    {
                        bll.ThemSinhVien(
                            txtMaSV.Text.Trim(),
                            txtHoVaTen.Text.Trim(),
                            gioiTinh,
                            dtpNgaySinh.Value,
                            (int)cboChuyenNganh.SelectedValue,
                            (int)cboNamTotNghiep.SelectedValue,
                            txtSoDienThoai.Text.Trim(),
                             txtEmail.Text.Trim(),
                            diemTB,
                            (int)cboXepLoai.SelectedValue,
                            (int)cboDVQL.SelectedValue,
                            trangThai
                        );
                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    HienThiDuLieu();
                    opt = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                opt = 2; // Đánh dấu đang ở chế độ sửa

                // Lấy dữ liệu từ DataGridView
                txtMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();

                // Xử lý giới tính
                string gioiTinh = row.Cells["Gioi_Tinh"].Value?.ToString();
                rdoNam.Checked = gioiTinh == "Nam";
                rdoNu.Checked = gioiTinh == "Nữ";

                // Ngày sinh
                if (row.Cells["Ngay_Sinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                }
                // Chọn combobox Chuyên ngành
                if (dgvSinhVien.DataSource != null)
                {
                    var data = (dgvSinhVien.DataSource as System.Collections.Generic.List<chon_sinhvien_Result>)[e.RowIndex];
                    cboChuyenNganh.SelectedValue = data.Ten_ChuyenNganh;
                    cboNamTotNghiep.SelectedValue = data.Nam_Ket_Thuc;
                    cboXepLoai.SelectedValue = data.Ten_XepLoai;
                    cboDVQL.SelectedValue = data.Ten_DonViQuanLy;
                }

                txtSoDienThoai.Text = row.Cells["So_Dien_Thoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiemTB.Text = row.Cells["Diem_Trung_Binh_Tich_Luy"].Value?.ToString();
                // Xử lý trạng thái
                string trangThai = row.Cells["Trang_Thai"].Value?.ToString();
                rdoDaTN.Checked = trangThai == "Đã tốt nghiệp";
                rdoChuaTN.Checked = trangThai == "Chưa tốt nghiệp";
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng nào chưa
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu hợp lệ
            if (!ValidateInput())
                return;

            try
            {
                // Lấy ID từ dòng đang chọn (đã được lưu trong biến opt hoặc từ DataGridView)
                int idSinhVien = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id_SinhVien"].Value);

                // Lấy dữ liệu từ các control
                bool gioiTinh = rdoNu.Checked;
                bool trangThai = rdoDaTN.Checked;
                decimal diemTB;

                if (!decimal.TryParse(txtDiemTB.Text, out diemTB))
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức sửa từ BLL
                bll.SuaSinhVien(
                    idSinhVien,
                    txtMaSV.Text.Trim(),
                    txtHoVaTen.Text.Trim(),
                    gioiTinh,
                    dtpNgaySinh.Value,
                    (int)cboChuyenNganh.SelectedValue,  // Lưu ý: Đây phải là ID, không phải tên
                    (int)cboNamTotNghiep.SelectedValue,      // Lưu ý: Đây phải là ID, không phải mã
                    txtSoDienThoai.Text.Trim(),
                    txtEmail.Text.Trim(),
                    diemTB,
                    (int)cboXepLoai.SelectedValue,      // Lưu ý: Đây phải là ID
                    (int)cboDVQL.SelectedValue,         // Lưu ý: Đây phải là ID
                    trangThai
                );

                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thành công",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu
                HienThiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id_SinhVien"].Value);
                    bll.XoaSinhVien(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                var tatCaSinhVien = bll.GetChon_Sinhvien_Results();
                var ketQua = tatCaSinhVien.AsQueryable(); // Sử dụng AsQueryable để hỗ trợ tìm kiếm không phân biệt hoa thường

                // Tìm kiếm không phân biệt hoa thường cho mã SV và họ tên
                if (!string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    string maSV = txtMaSV.Text.Trim().ToLower();
                    ketQua = ketQua.Where(sv => sv.Ma_SinhVien.ToLower().Contains(maSV));
                }

                if (!string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                {
                    string hoTen = txtHoVaTen.Text.Trim().ToLower();
                    ketQua = ketQua.Where(sv => sv.Ho_Va_Ten.ToLower().Contains(hoTen));
                }

                // Các điều kiện tìm kiếm khác giữ nguyên
                if (rdoNam.Checked || rdoNu.Checked)
                {
                    string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    ketQua = ketQua.Where(sv => sv.Gioi_Tinh == gioiTinh);
                }

                if (cboChuyenNganh.SelectedIndex != -1)
                {
                    string chuyenNganh = cboChuyenNganh.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_ChuyenNganh == chuyenNganh);
                }

                if (!string.IsNullOrWhiteSpace(txtDiemTB.Text) && decimal.TryParse(txtDiemTB.Text, out decimal diem))
                {
                    ketQua = ketQua.Where(sv => sv.Diem_Trung_Binh_Tich_Luy == diem);
                }

                if (cboDVQL.SelectedIndex != -1)
                {
                    string donViQL = cboDVQL.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_DonViQuanLy == donViQL);
                }


                if (cboXepLoai.SelectedIndex != -1)
                {
                    string xepLoai = cboXepLoai.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_XepLoai == xepLoai);
                }

                if (rdoDaTN.Checked || rdoChuaTN.Checked)
                {
                    string trangThai = rdoDaTN.Checked ? "Đã tốt nghiệp" : "Chưa tốt nghiệp";
                    ketQua = ketQua.Where(sv => sv.Trang_Thai == trangThai);
                }

                // Thực hiện truy vấn và hiển thị kết quả
                var ketQuaCuoiCung = ketQua.ToList();
                dgvSinhVien.DataSource = ketQuaCuoiCung;

                if (!ketQuaCuoiCung.Any())
                {
                    MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvSinhVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                opt = 2; // Đánh dấu đang ở chế độ sửa

                // Lấy dữ liệu từ DataGridView
                txtMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();

                // Xử lý giới tính
                string gioiTinh = row.Cells["Gioi_Tinh"].Value?.ToString();
                rdoNam.Checked = gioiTinh == "Nam";
                rdoNu.Checked = gioiTinh == "Nữ";

                // Ngày sinh
                if (row.Cells["Ngay_Sinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                }
                // Chọn combobox Chuyên ngành
                if (dgvSinhVien.DataSource != null)
                {
                    var data = (dgvSinhVien.DataSource as System.Collections.Generic.List<chon_sinhvien_Result>)[e.RowIndex];
                    cboChuyenNganh.SelectedValue = data.Ten_ChuyenNganh;
                    cboNamTotNghiep.SelectedValue = data.Nam_Ket_Thuc;
                    cboXepLoai.SelectedValue = data.Ten_XepLoai;
                    cboDVQL.SelectedValue = data.Ten_DonViQuanLy;
                }

                txtSoDienThoai.Text = row.Cells["So_Dien_Thoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiemTB.Text = row.Cells["Diem_Trung_Binh_Tich_Luy"].Value?.ToString();
                // Xử lý trạng thái
                string trangThai = row.Cells["Trang_Thai"].Value?.ToString();
                rdoDaTN.Checked = trangThai == "Đã tốt nghiệp";
                rdoChuaTN.Checked = trangThai == "Chưa tốt nghiệp";
            }


        }
    }
}

