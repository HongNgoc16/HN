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
    public partial class ucXepLoaiTotNghiep : UserControl
    {
        int opt = -1;
        private dm_XepLoaiTN_BLL bll = new dm_XepLoaiTN_BLL();
        public ucXepLoaiTotNghiep()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgXepLoai.DataSource = bll.GetChon_Xeploai_Results();
        }
        private void ucXepLoaiTotNghiep_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaXL.Clear();
            textTenXL.Clear();
            textDiemToiThieu.Clear();
            textDiemToiDa.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            textMaXL.Focus();
            opt = 1;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;
            if (dgXepLoai.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgXepLoai[0, dgXepLoai.CurrentRow.Index].Value);
                bll.SuaXepLoai(id, textMaXL.Text, textTenXL.Text,
                               Convert.ToDecimal(textDiemToiThieu.Text),
                               Convert.ToDecimal(textDiemToiDa.Text),
                               trang_Thai_Su_Dung);
                HienThiDuLieu();
                MessageBox.Show("Sửa xếp loại thành công!");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgXepLoai.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgXepLoai[0, dgXepLoai.CurrentRow.Index].Value);
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.XoaXepLoai(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa xếp loại thành công!");
                }
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;

            if (opt == 1)
            {
                bll.ThemXepLoai(textMaXL.Text, textTenXL.Text,
                                Convert.ToDecimal(textDiemToiThieu.Text),
                                Convert.ToDecimal(textDiemToiDa.Text),
                                trang_Thai_Su_Dung);
                HienThiDuLieu();
                MessageBox.Show("Thêm xếp loại thành công!");
                opt = -1;
            }
        }

        private void dgXepLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textMaXL.Text = dgXepLoai[1, dgXepLoai.CurrentRow.Index].Value.ToString();
                textTenXL.Text = dgXepLoai[2, dgXepLoai.CurrentRow.Index].Value.ToString();
                textDiemToiThieu.Text = dgXepLoai[3, dgXepLoai.CurrentRow.Index].Value.ToString();
                textDiemToiDa.Text = dgXepLoai[4, dgXepLoai.CurrentRow.Index].Value.ToString();

                bool trang_Thai_Su_Dung = Convert.ToBoolean(dgXepLoai[5, e.RowIndex].Value); // Assuming column 5 holds the "TrangThaiSuDung" value.
                rdbDangSd.Checked = trang_Thai_Su_Dung;
                rdbKhongSd.Checked = !trang_Thai_Su_Dung;

        }
    }

}
