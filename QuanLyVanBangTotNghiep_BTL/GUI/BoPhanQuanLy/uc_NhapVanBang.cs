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
using static QuanLyVanBangTotNghiep_BTL.DAL.VanBang_DAL;
namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    public partial class uc_NhapVanBang : UserControl
    {
        private VanBang_BLL bll = new VanBang_BLL();
        private int opt = -1;
        public uc_NhapVanBang()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgVanBang.DataSource = bll.GetChon_Vanbang_Results();
        }

        private void uc_NhapVanBang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
           formThemVanBang form = new formThemVanBang();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Sau khi thêm thành công → gọi lại Load DataGridView
                HienThiDuLieu();
            }
        }
    }
}
