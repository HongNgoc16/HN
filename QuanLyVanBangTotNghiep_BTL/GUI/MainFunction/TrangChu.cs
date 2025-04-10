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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Show();
        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuVanBang traCuu = new TraCuuVanBang();
            this.Hide();
            traCuu.ShowDialog();
            this.Show();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            DangKyCapBanSao dangKyCapBanSao = new DangKyCapBanSao();
            this.Hide();
            dangKyCapBanSao.ShowDialog();
            this.Show();
        }

        private void buttonGuiYeuCau_Click(object sender, EventArgs e)
        {
            GuiYeuCauChinhSua guiYeuCau = new GuiYeuCauChinhSua();
            this.Hide();
            guiYeuCau.ShowDialog();
            this.Show();
        }

        private void buttonHuongDan_Click(object sender, EventArgs e)
        {

        }
    }
}
