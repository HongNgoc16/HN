using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class QuanTriVien : Form
    {
        public QuanTriVien()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelChucNang.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelChucNang.Controls.Add(uc);
        }
        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucNguoiDung());
        }

        private void buttonDonViQuanLy_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDonViQuanLy());
        }

        private void buttonNganhHoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucNganhHoc());
        }

        private void buttonChuyenNganh_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucChuyenNganh());
        }

        private void buttonKhoaHoc_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucKhoaHoc());
        }

        private void buttonLoaiTotNghiep_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucXepLoaiTotNghiep());
        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucSinhVien());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            panelChucNang.Controls.Clear();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question );
            if ( result == DialogResult.OK )
            {
                this.Hide();
                TrangChu trangChu = new TrangChu();
              //  trangChu.Show();
            }
        }

        private void QuanTriVien_Load(object sender, EventArgs e)
        {

        }
    }
}
