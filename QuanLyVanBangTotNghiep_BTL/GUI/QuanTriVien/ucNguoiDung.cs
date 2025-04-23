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
    public partial class UcNguoiDung : UserControl
    {
        private dm_NguoiDung_BLL bll = new dm_NguoiDung_BLL();
        int opt = -1;
        public UcNguoiDung()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgvNguoiDung.DataSource= bll.GetChon_Nguoidung_Results();
        }
        private void UcNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cboLoaiND.Items.Clear();
            cboLoaiND.Items.AddRange(new string[] { "qtv", "bpql", "bpd" });
            cboLoaiND.SelectedIndex = 0;
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaND .Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear   ();
            cboLoaiND.SelectedIndex = -1;
            txtMaND.Focus();
            opt = 1;

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvNguoiDung[0, dgvNguoiDung.CurrentRow.Index].Value);
                bll.SuaNguoiDung(id, txtMaND.Text, txtTenDangNhap.Text, txtMatKhau.Text, cboLoaiND.Text);
                HienThiDuLieu();
                MessageBox.Show("Sửa thông tin người dùng thành công!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvNguoiDung[0, dgvNguoiDung.CurrentRow.Index].Value);
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

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiND.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại người dùng!");
                return;
            }
           if (opt == 1)
            {
                bll.ThemNguoiDung(txtMaND.Text, txtTenDangNhap.Text, txtMatKhau.Text, cboLoaiND.SelectedItem.ToString());
                HienThiDuLieu();
                MessageBox.Show("Thêm người dùng thành công!");
            }
        }

        private void DgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaND.Text = dgvNguoiDung[1, e.RowIndex].Value.ToString();
                txtTenDangNhap.Text = dgvNguoiDung[2, e.RowIndex].Value.ToString();
                txtMatKhau.Text = dgvNguoiDung[3, e.RowIndex].Value.ToString();
                cboLoaiND.Text = dgvNguoiDung[4, e.RowIndex].Value.ToString();
            }
        }
    }
}
