using QuanLyVanBangTotNghiep_BTL.BLL;
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
    public partial class uc_DuyetVanBang : UserControl
    {
        VanBangTam_BLL vbtam = new VanBangTam_BLL();
        public uc_DuyetVanBang()
        {
            InitializeComponent();
        }
        private void LoadDanhSachVanBang()
        {
            var danhSach = vbtam.GetChon_Vanbangtam_Results(); // Viết hàm BLL gọi SP lấy vanbangtam
            dgDuyet.DataSource = danhSach;
        }
    }
}
