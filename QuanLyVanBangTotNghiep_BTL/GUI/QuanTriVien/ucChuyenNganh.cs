using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{

    
    public partial class ucChuyenNganh : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public ucChuyenNganh()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgChuyenNganh.DataSource = db.chon_chuyennganh();
        }

        private void ucChuyenNganh_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
    }
}
