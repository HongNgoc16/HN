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
    public partial class BPDuyet : Form
    {
        public BPDuyet()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelChucNang.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelChucNang.Controls.Add(uc);
        }
        private void BPDuyet_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDuyetVB_Click(object sender, EventArgs e)
        {
            LoadUserControl(new uc_DuyetVanBang());
        }

        private void buttonDuyetYC_Click(object sender, EventArgs e)
        {
            LoadUserControl (new uc_DuyetYCChinhSua());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            panelChucNang.Controls.Clear();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                TrangChu trangChu = new TrangChu();
            }
        }
    }
}
