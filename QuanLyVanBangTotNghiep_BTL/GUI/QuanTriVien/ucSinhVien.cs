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
    public partial class ucSinhVien : UserControl
    {
        private dm_SinhVien_BLL bll = new dm_SinhVien_BLL();
        int opt = -1;
        public ucSinhVien()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgSinhVien.DataSource = bll.GetChon_Sinhvien_Results();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
