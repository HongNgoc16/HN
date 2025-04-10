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
    public partial class ucNguoiDung : UserControl
    {
        private dm_NguoiDung_BLL bll = new dm_NguoiDung_BLL();
        int opt = -1;
        public ucNguoiDung()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgNguoiDung.DataSource= bll.GetChon_Nguoidung_Results();
        }
        private void ucNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cboBoxLoaiND.Items.Clear();
            cboBoxLoaiND.Items.AddRange(new string[] { "qtv", "bpql", "bpd" });
            cboBoxLoaiND.SelectedIndex = 0;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaND .Clear();
            textTenDangNhap.Clear();
            textMatKhau.Clear   ();
            cboBoxLoaiND.SelectedIndex = -1;
            textMaND.Focus();
            opt = 1;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgNguoiDung.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgNguoiDung[0, dgNguoiDung.CurrentRow.Index].Value);
                bll.SuaNguoiDung(id, textMaND.Text, textTenDangNhap.Text, textMatKhau.Text, cboBoxLoaiND.Text);
                HienThiDuLieu();
                MessageBox.Show("Sửa thông tin người dùng thành công!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgNguoiDung.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgNguoiDung[0, dgNguoiDung.CurrentRow.Index].Value);
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.XoaNguoiDung(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa người dùng thành công!");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (cboBoxLoaiND.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại người dùng!");
                return;
            }
           if (opt == 1)
            {
                bll.ThemNguoiDung(textMaND.Text, textTenDangNhap.Text, textMatKhau.Text, cboBoxLoaiND.SelectedItem.ToString());
                HienThiDuLieu();
                MessageBox.Show("Thêm người dùng thành công!");
            }
        }

        private void dgNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textMaND.Text = dgNguoiDung[1, e.RowIndex].Value.ToString();
                textTenDangNhap.Text = dgNguoiDung[2, e.RowIndex].Value.ToString();
                textMatKhau.Text = dgNguoiDung[3, e.RowIndex].Value.ToString();
                cboBoxLoaiND.Text = dgNguoiDung[4, e.RowIndex].Value.ToString();
            }
        }
    }
}
