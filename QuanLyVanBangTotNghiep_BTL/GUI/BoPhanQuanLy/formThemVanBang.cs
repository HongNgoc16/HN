using QuanLyVanBangTotNghiep_BTL.BLL;
using QuanLyVanBangTotNghiep_BTL.DAL;
using QuanLyVanBangTotNghiep_BTL.GUI.BoPhanDuyet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class formThemVanBang : Form
    {
        QLVB_Entities db = new QLVB_Entities();
        VanBangTam_BLL vb = new VanBangTam_BLL();  // Sử dụng BLL mới cho văn bằng tạm
        LayThongTin_BLL bll = new LayThongTin_BLL();
        private int hidden_IdSinhVien = -1;

        public formThemVanBang()
        {
            InitializeComponent();
        }

        private void formThemVanBang_Load(object sender, EventArgs e)
        {
            // Load danh sách đợt cấp
            comboBoxDotCap.DataSource = db.chon_dot_cap().ToList();
            comboBoxDotCap.DisplayMember = "Ten_Dot_Cap";
            comboBoxDotCap.ValueMember = "Id_Dot_Cap";
        }

        private void textMaSV_Leave(object sender, EventArgs e)
        {
            HienThongTinSinhVien();
        }

        private void HienThongTinSinhVien()
        {
            string maSV = textMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
                return;

            var sv = bll.LayThongTinTheoMaSV(maSV);

            if (sv != null)
            {
                textHoVaTen.Text = sv.Ho_Va_Ten;
                textNganhHoc.Text = sv.Ten_Nganh;
                textChuyenNganh.Text = sv.Ten_ChuyenNganh;
                textKhoaHoc.Text = sv.Ma_KhoaHoc;
                textXepLoai.Text = sv.Ten_XepLoai;
                hidden_IdSinhVien = sv.Id_SinhVien;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textHoVaTen.Clear();
                textNganhHoc.Clear();
                textChuyenNganh.Clear();
                textKhoaHoc.Clear();
                textXepLoai.Clear();
                hidden_IdSinhVien = -1;
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // Không cần thiết xử lý ở đây vì chúng ta sẽ sử dụng button "Gửi Duyệt" để gửi yêu cầu duyệt
        }

        private void buttonGuiDuyet_Click(object sender, EventArgs e)
        {
            if (hidden_IdSinhVien == -1)
            {
                MessageBox.Show("Chưa có sinh viên hợp lệ.");
                return;
            }

            // Lấy dữ liệu từ form
            string soHieu = textSHVB.Text.Trim();
            string noiCap = textNoiCap.Text.Trim();
            DateTime ngayCap = dateTimeNgayCap.Value;
            int idDotCap = (int)comboBoxDotCap.SelectedValue;

            // Kiểm tra dữ liệu cần thiết
            if (string.IsNullOrEmpty(soHieu))
            {
                MessageBox.Show("Vui lòng nhập số hiệu văn bằng.");
                return;
            }

            if (string.IsNullOrEmpty(noiCap))
            {
                MessageBox.Show("Vui lòng nhập nơi cấp.");
                return;
            }

            try
            {
                // Gọi BLL để thêm vào bảng VanBangTam
                vb.ThemVanBangTam(soHieu, idDotCap, hidden_IdSinhVien, ngayCap, noiCap);

                MessageBox.Show("Đã gửi yêu cầu duyệt văn bằng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form nếu muốn
                textSHVB.Clear();
                textNoiCap.Clear();
                textMaSV.Clear();
                textHoVaTen.Clear();
                textNganhHoc.Clear();
                textChuyenNganh.Clear();
                textKhoaHoc.Clear();
                textXepLoai.Clear();
                hidden_IdSinhVien = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
