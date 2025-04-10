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
    public partial class DangNhap : Form
    {
        private dm_NguoiDung_BLL bll = new dm_NguoiDung_BLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void checkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            textMatKhau.UseSystemPasswordChar = !checkHienThiMK.Checked;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = textTenDangNhap.Text.Trim();
            string matKhau = textMatKhau.Text.Trim();

            var users = bll.GetChon_Nguoidung_Results();
            var user = users.FirstOrDefault(u => u.Ten_Dang_Nhap == tenDangNhap && u.Mat_Khau == matKhau);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                switch (user.Loai_NguoiDung)
                {
                    case "qtv":
                        new QuanTriVien().ShowDialog();
                        break;
                    case "bpql":
                        new BPQuanLy().ShowDialog();
                        break;
                    case "bpd":
                        new BPDuyet().ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Loại người dùng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

              //  this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TrangChu().ShowDialog();
            //this.Show();
        }
    }
       
   
}
