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
namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    public partial class uc_DotCapVanBang : UserControl
    {
        private DotCap_BLL bll = new DotCap_BLL();
        int opt = -1;
        public uc_DotCapVanBang()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgDotCap.DataSource = bll.GetChon_Dot_Cap_Results();
        }


        private void uc_DotCapVanBang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textTenDotCap.Clear();
            textTenDotCap.Focus();
            opt = 1;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgDotCap.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgDotCap.CurrentRow.Cells["Id_Dot_Cap"].Value);
                string ten = textTenDotCap.Text;
                bll.SuaDotCap(id, ten);
                MessageBox.Show("Sửa thành công!");
                HienThiDuLieu();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgDotCap.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgDotCap.CurrentRow.Cells["Id_Dot_Cap"].Value);
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bll.XoaDotCap(id);
                    MessageBox.Show("Xóa thành công!");
                    HienThiDuLieu();
                }
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (opt == 1)
            {
                bll.ThemDotCap(textTenDotCap.Text);
                MessageBox.Show("Thêm đợt cấp thành công!");
                HienThiDuLieu();
                opt = -1;
            }
        }

        private void dgDotCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDotCap.CurrentRow != null)
            {
                textTenDotCap.Text = dgDotCap.CurrentRow.Cells["Ten_Dot_Cap"].Value.ToString();
            }
        }
    }
}
