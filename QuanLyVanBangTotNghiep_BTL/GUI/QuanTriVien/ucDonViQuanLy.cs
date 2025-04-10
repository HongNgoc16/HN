using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL.BLL;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucDonViQuanLy : UserControl
    {
        int opt = -1;
        private dm_DonViQuanLy_BLL bll = new dm_DonViQuanLy_BLL();
        public ucDonViQuanLy()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgDonViQuanLy.DataSource = bll.GetChon_Donviquanly_Results();
        }
        private void ucDonViQuanLy_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            //dgDonViQuanLy.CellFormatting += dgDonViQuanLy_CellFormatting;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaDVQL.Clear();
            textTenDVQL.Clear();
            textTenDVQLCha.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            textMaDVQL.Focus();
            opt = 1;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgDonViQuanLy.CurrentRow != null)
            {
                bool trang_Thai_Su_Dung = rdbDangSd.Checked;
                int id = Convert.ToInt32(dgDonViQuanLy[0, dgDonViQuanLy.CurrentRow.Index].Value.ToString());
                bll.SuaDonViQuanLy(id, textMaDVQL.Text, textTenDVQL.Text, textTenDVQLCha.Text, trang_Thai_Su_Dung);
                HienThiDuLieu();
                MessageBox.Show("Sửa đơn vị quản lý thành công!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgDonViQuanLy.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgDonViQuanLy[0, dgDonViQuanLy.CurrentRow.Index].Value.ToString());
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.XoaDonViQuanLy(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa đơn vị quản lý thành công!");

                }
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;
            if (opt == 1)
            {
                bll.ThemDonViQuanLy (textMaDVQL.Text, textTenDVQL.Text, textTenDVQLCha.Text, trang_Thai_Su_Dung);
                HienThiDuLieu ();
                MessageBox.Show("Thêm đơn vị quản lý thành công!");
                opt = -1;
            }
        }

        private void dgDonViQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaDVQL.Text = dgDonViQuanLy[1, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            textTenDVQL.Text = dgDonViQuanLy[2, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            textTenDVQLCha.Text = dgDonViQuanLy[3, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            bool trang_Thai_Su_Dung = Convert.ToBoolean(dgDonViQuanLy[4, e.RowIndex].Value);
            rdbDangSd.Checked = trang_Thai_Su_Dung;
            rdbKhongSd.Checked = !trang_Thai_Su_Dung;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
