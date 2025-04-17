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
            comboBoxChuyenNganh.DataSource = db.dm_ChuyenNganh.Where(c => c.Trang_Thai_Su_Dung == true).ToList();
            comboBoxChuyenNganh.DisplayMember = "Ten_ChuyenNganh";
            comboBoxChuyenNganh.ValueMember = "Id_ChuyenNganh";

            comboBoxKhoaHoc.DataSource = db.dm_KhoaHoc.Where(k => k.Trang_Thai == true).ToList();
            comboBoxKhoaHoc.DisplayMember = "Ma_KhoaHoc";
            comboBoxKhoaHoc.ValueMember = "Id_KhoaHoc";

            comboBoxDVQL.DataSource = db.dm_DonViQuanLy.Where(d => d.Trang_Thai_Su_Dung == true).ToList();
            comboBoxDVQL.DisplayMember = "Ten_DonViQuanLy";
            comboBoxDVQL.ValueMember = "Id_DonViQuanLy";

            comboBoxXepLoai.DataSource = db.dm_XepLoai.Where(x => x.Trang_Thai_Su_Dung == true).ToList();
            comboBoxXepLoai.DisplayMember = "Ten_XepLoai"; 
            comboBoxXepLoai.ValueMember = "Id_XepLoai";
        }
            private void HienThiDuLieu()
        {
            dgSinhVien.DataSource = bll.GetChon_Sinhvien_Results();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaSV.Clear();
            textHoVaTen.Clear();
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateNgaySinh.Value = DateTime.Now;
            comboBoxChuyenNganh.SelectedIndex = -1;
            textSoDienThoai.Clear();
            textEmail.Clear();
            textDiemTB.Clear();
            comboBoxKhoaHoc.SelectedIndex = -1;
            comboBoxDVQL.SelectedIndex = -1;
            comboBoxXepLoai.SelectedIndex = -1;
            radioButtonDaTN.Checked = false;
            radioButtonChuaTN.Checked = false;
            textMaSV.Focus();   
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
            if (string.IsNullOrWhiteSpace(textMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textMaSV.Focus();
                return false;
            }

            // Validate Họ và tên
            if (string.IsNullOrWhiteSpace(textHoVaTen.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textHoVaTen.Focus();
                return false;
            }

            // Validate Giới tính (sửa lại tên RadioButton)
            if (!radioButtonNam.Checked && !radioButtonNu.Checked) // Đổi từ radioButtonDaTN sang radioButtonNam/Nu
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Chuyên ngành
            if (comboBoxChuyenNganh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxChuyenNganh.Focus();
                return false;
            }

            // Validate Khóa học
            if (comboBoxKhoaHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxKhoaHoc.Focus();
                return false;
            }

            // Validate Số điện thoại
            if (string.IsNullOrWhiteSpace(textSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSoDienThoai.Focus();
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Email không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Focus();
                return false;
            }
            else if (!textEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Focus();
                return false;
            }

            // Validate Điểm trung bình
            if (!decimal.TryParse(textDiemTB.Text, out decimal diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải từ 0.00 đến 10.00!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDiemTB.Focus();
                return false;
            }

            // Validate Xếp loại
            if (comboBoxXepLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn xếp loại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxXepLoai.Focus();
                return false;
            }

            // Validate Đơn vị quản lý
            if (comboBoxDVQL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị quản lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxDVQL.Focus();
                return false;
            }

            // Validate Trạng thái (sửa lại tên RadioButton)
            if (!radioButtonDaTN.Checked && !radioButtonChuaTN.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái tốt nghiệp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




        private void buttonLuu_Click(object sender, EventArgs e)
        {
            {
                if (!ValidateInput()) return;

                try
                {
                    bool gioiTinh = radioButtonNu.Checked;
                    bool trangThai = radioButtonDaTN.Checked;
                    decimal diemTB = decimal.Parse(textDiemTB.Text);

                    if (opt == 1) // Thêm mới
                    {
                        bll.ThemSinhVien(
                            textMaSV.Text.Trim(),
                            textHoVaTen.Text.Trim(),
                            gioiTinh,
                            dateNgaySinh.Value,
                            (int)comboBoxChuyenNganh.SelectedValue,
                            (int)comboBoxKhoaHoc.SelectedValue,
                            textSoDienThoai.Text.Trim(),
                             textEmail.Text.Trim(),
                            diemTB,
                            (int)comboBoxXepLoai.SelectedValue,
                            (int)comboBoxDVQL.SelectedValue,
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

        private void dgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgSinhVien.Rows.Count)
            {
                var row = dgSinhVien.Rows[e.RowIndex];
                opt = 2; // Đánh dấu đang ở chế độ sửa

                // Lấy dữ liệu từ DataGridView
                textMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
                textHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();

                // Xử lý giới tính
                string gioiTinh = row.Cells["Gioi_Tinh"].Value?.ToString();
                radioButtonNam.Checked = gioiTinh == "Nam";
                radioButtonNu.Checked = gioiTinh == "Nữ";

                // Ngày sinh
                if (row.Cells["Ngay_Sinh"].Value != null)
                {
                    dateNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                }
                // Chọn combobox Chuyên ngành
                if (dgSinhVien.DataSource != null)
                {
                    var data = (dgSinhVien.DataSource as System.Collections.Generic.List<chon_sinhvien_Result>)[e.RowIndex];
                    comboBoxChuyenNganh.SelectedValue = data.Ten_ChuyenNganh;
                    comboBoxKhoaHoc.SelectedValue = data.Ma_KhoaHoc;
                    comboBoxXepLoai.SelectedValue = data.Ten_XepLoai;
                    comboBoxDVQL.SelectedValue = data.Ten_DonViQuanLy;
                }

                textSoDienThoai.Text = row.Cells["So_Dien_Thoai"].Value?.ToString();
                textEmail.Text = row.Cells["Email"].Value?.ToString();
                textDiemTB.Text = row.Cells["Diem_Trung_Binh_Tich_Luy"].Value?.ToString();
                // Xử lý trạng thái
                string trangThai = row.Cells["Trang_Thai"].Value?.ToString();
                radioButtonDaTN.Checked = trangThai == "Đã tốt nghiệp";
                radioButtonChuaTN.Checked = trangThai == "Chưa tốt nghiệp";
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn dòng nào chưa
            if (dgSinhVien.CurrentRow == null)
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
                int idSinhVien = Convert.ToInt32(dgSinhVien.CurrentRow.Cells["Id_SinhVien"].Value);

                // Lấy dữ liệu từ các control
                bool gioiTinh = radioButtonNu.Checked;
                bool trangThai = radioButtonDaTN.Checked;
                decimal diemTB;

                if (!decimal.TryParse(textDiemTB.Text, out diemTB))
                {
                    MessageBox.Show("Điểm trung bình không hợp lệ!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức sửa từ BLL
                bll.SuaSinhVien(
                    idSinhVien,
                    textMaSV.Text.Trim(),
                    textHoVaTen.Text.Trim(),
                    gioiTinh,
                    dateNgaySinh.Value,
                    (int)comboBoxChuyenNganh.SelectedValue,  // Lưu ý: Đây phải là ID, không phải tên
                    (int)comboBoxKhoaHoc.SelectedValue,      // Lưu ý: Đây phải là ID, không phải mã
                    textSoDienThoai.Text.Trim(),
                    textEmail.Text.Trim(),
                    diemTB,
                    (int)comboBoxXepLoai.SelectedValue,      // Lưu ý: Đây phải là ID
                    (int)comboBoxDVQL.SelectedValue,         // Lưu ý: Đây phải là ID
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgSinhVien.CurrentRow.Cells["Id_SinhVien"].Value);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var tatCaSinhVien = bll.GetChon_Sinhvien_Results();
                var ketQua = tatCaSinhVien.AsQueryable(); // Sử dụng AsQueryable để hỗ trợ tìm kiếm không phân biệt hoa thường

                // Tìm kiếm không phân biệt hoa thường cho mã SV và họ tên
                if (!string.IsNullOrWhiteSpace(textMaSV.Text))
                {
                    string maSV = textMaSV.Text.Trim().ToLower();
                    ketQua = ketQua.Where(sv => sv.Ma_SinhVien.ToLower().Contains(maSV));
                }

                if (!string.IsNullOrWhiteSpace(textHoVaTen.Text))
                {
                    string hoTen = textHoVaTen.Text.Trim().ToLower();
                    ketQua = ketQua.Where(sv => sv.Ho_Va_Ten.ToLower().Contains(hoTen));
                }

                // Các điều kiện tìm kiếm khác giữ nguyên
                if (radioButtonNam.Checked || radioButtonNu.Checked)
                {
                    string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
                    ketQua = ketQua.Where(sv => sv.Gioi_Tinh == gioiTinh);
                }

                if (comboBoxChuyenNganh.SelectedIndex != -1)
                {
                    string chuyenNganh = comboBoxChuyenNganh.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_ChuyenNganh == chuyenNganh);
                }

                if (!string.IsNullOrWhiteSpace(textDiemTB.Text) && decimal.TryParse(textDiemTB.Text, out decimal diem))
                {
                    ketQua = ketQua.Where(sv => sv.Diem_Trung_Binh_Tich_Luy == diem);
                }

                if (comboBoxDVQL.SelectedIndex != -1)
                {
                    string donViQL = comboBoxDVQL.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_DonViQuanLy == donViQL);
                }

                if (comboBoxKhoaHoc.SelectedIndex != -1)
                {
                    string khoaHoc = comboBoxKhoaHoc.Text;
                    ketQua = ketQua.Where(sv => sv.Ma_KhoaHoc == khoaHoc);
                }

                if (comboBoxXepLoai.SelectedIndex != -1)
                {
                    string xepLoai = comboBoxXepLoai.Text;
                    ketQua = ketQua.Where(sv => sv.Ten_XepLoai == xepLoai);
                }

                if (radioButtonDaTN.Checked || radioButtonChuaTN.Checked)
                {
                    string trangThai = radioButtonDaTN.Checked ? "Đã tốt nghiệp" : "Chưa tốt nghiệp";
                    ketQua = ketQua.Where(sv => sv.Trang_Thai == trangThai);
                }

                // Thực hiện truy vấn và hiển thị kết quả
                var ketQuaCuoiCung = ketQua.ToList();
                dgSinhVien.DataSource = ketQuaCuoiCung;

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

        private void dgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSinhVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgSinhVien.Rows.Count)
            {
                var row = dgSinhVien.Rows[e.RowIndex];
                opt = 2; // Đánh dấu đang ở chế độ sửa

                // Lấy dữ liệu từ DataGridView
                textMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
                textHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();

                // Xử lý giới tính
                string gioiTinh = row.Cells["Gioi_Tinh"].Value?.ToString();
                radioButtonNam.Checked = gioiTinh == "Nam";
                radioButtonNu.Checked = gioiTinh == "Nữ";

                // Ngày sinh
                if (row.Cells["Ngay_Sinh"].Value != null)
                {
                    dateNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
                }
                // Chọn combobox Chuyên ngành
                if (dgSinhVien.DataSource != null)
                {
                    var data = (dgSinhVien.DataSource as System.Collections.Generic.List<chon_sinhvien_Result>)[e.RowIndex];
                    comboBoxChuyenNganh.SelectedValue = data.Ten_ChuyenNganh;
                    comboBoxKhoaHoc.SelectedValue = data.Ma_KhoaHoc;
                    comboBoxXepLoai.SelectedValue = data.Ten_XepLoai;
                    comboBoxDVQL.SelectedValue = data.Ten_DonViQuanLy;
                }

                textSoDienThoai.Text = row.Cells["So_Dien_Thoai"].Value?.ToString();
                textEmail.Text = row.Cells["Email"].Value?.ToString();
                textDiemTB.Text = row.Cells["Diem_Trung_Binh_Tich_Luy"].Value?.ToString();
                // Xử lý trạng thái
                string trangThai = row.Cells["Trang_Thai"].Value?.ToString();
                radioButtonDaTN.Checked = trangThai == "Đã tốt nghiệp";
                radioButtonChuaTN.Checked = trangThai == "Chưa tốt nghiệp";
            }


        }
    }
}

