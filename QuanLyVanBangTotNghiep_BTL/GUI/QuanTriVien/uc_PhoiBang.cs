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
    public partial class uc_PhoiBang : UserControl
    {
        private PhoiBang_BLL bll = new PhoiBang_BLL();
        int opt = -1;

        public void HienThiDuLieu()
        {
            dgPhoiBang.DataSource = bll.GetChon_Phoibang_Results();
        }

        public uc_PhoiBang()
        {
            InitializeComponent();
        }

        private void uc_PhoiBang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            comboBoxTrangThai.Items.Clear();
            comboBoxTrangThai.Items.AddRange(new string[] { "Chưa cấp", "Đã cấp", "Đã hủy" });
            comboBoxTrangThai.SelectedIndex = 0;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textSoHieuPhoi.Clear();
            dtpNgayNhap.Value = DateTime.Today;
            textGhiChu.Clear();
            comboBoxTrangThai.SelectedIndex = -1;
            textSoHieuPhoi.Focus();
            opt = 1;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxTrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái!");
                return;
            }
            int trangThai = 0; // default = "Chưa cấp"
            switch (comboBoxTrangThai.Text)
            {
                case "Đã cấp":
                    trangThai = 1;
                    break;
                case "Đã hủy":
                    trangThai = 2;
                    break;
            }

            if (opt == 1)
            {
                bll.ThemPhoiBang(textSoHieuPhoi.Text, dtpNgayNhap.Value, textGhiChu.Text, trangThai);
                HienThiDuLieu();
                MessageBox.Show("Thêm phôi bằng thành công!");
            }
        }
    }
}
