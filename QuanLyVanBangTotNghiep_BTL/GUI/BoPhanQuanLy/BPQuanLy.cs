using QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy;
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
    public partial class BPQuanLy : Form
    {
        public BPQuanLy()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelChucNang.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelChucNang.Controls.Add(uc);
        }
        private void BPQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void buttonDotCapVB_Click(object sender, EventArgs e)
        {
            LoadUserControl (new uc_DotCapVanBang());   
        }

        private void buttonNhapVB_Click(object sender, EventArgs e)
        {
            LoadUserControl(new uc_NhapVanBang());
        }

        private void buttonChínhuaVB_Click(object sender, EventArgs e)
        {
            LoadUserControl(new uc_ChinhSuaVanBang());  
        }

        private void buttonQuanLyBanSao_Click(object sender, EventArgs e)
        {
            LoadUserControl(new uc_CapBanSao());
        }

        private void buttonBienBanHuyBang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new uc_BienBanHuyBang());
        }

        private void buttonQuanLyVBHuy_Click(object sender, EventArgs e)
        {
            
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
