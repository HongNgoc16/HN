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

namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanDuyet
{
    public partial class formDuyetVanBang : Form
    {
        private int _maVanBangTam;
        public formDuyetVanBang()
        {
            InitializeComponent();
        }
        public formDuyetVanBang(DataGridViewRow row)
        {

            InitializeComponent();

            _maVanBangTam = Convert.ToInt32(row.Cells["MaVanBangTam"].Value);

            comboBoxDotCap.Text = row.Cells["TenDotCap"].Value?.ToString();
            textMaSV.Text = row.Cells["MaSinhVien"].Value?.ToString();
            textHoVaTen.Text = row.Cells["HoTen"].Value?.ToString();
            dateTimeNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            textNganhHoc.Text = row.Cells["TenNganh"].Value?.ToString();
            textChuyenNganh.Text = row.Cells["TenChuyenNganh"].Value?.ToString();
            textKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString();
            textXepLoai.Text = row.Cells["TenXepLoai"].Value?.ToString();
            textSHVB.Text = row.Cells["SoHieuVanBang"].Value?.ToString();
            dateTimeNgayCap.Value = Convert.ToDateTime(row.Cells["NgayCap"].Value);
            textNoiCap.Text = row.Cells["NoiCap"].Value?.ToString();
        }

        private void formDuyetVanBang_Load(object sender, EventArgs e)
        {

        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            var bll = new VanBangTam_BLL();
            bool result = bll.CapNhatTrangThai(_maVanBangTam, 1); // 1: Đã duyệt
            MessageBox.Show(result ? "Duyệt thành công!" : "Lỗi khi duyệt!");
            this.Close();
        }

        private void buttonTuChoi_Click(object sender, EventArgs e)
        {

        }
    }
}
