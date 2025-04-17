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
    public partial class TraCuuVanBang : Form
    {
        VanBangCT_BLL bll = new VanBangCT_BLL();
        public TraCuuVanBang()
        {
            InitializeComponent();
        }

     
        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            string maSinhVien = textMaSV.Text.Trim();
            string hoVaTen = textHoVaTen.Text.Trim();
            string soHieu = textSoHieuVB.Text.Trim();

            // Gọi BLL để tìm kiếm dữ liệu
            var ketQua = bll.TraCuuVanBang(maSinhVien, hoVaTen, soHieu);

            // Hiển thị kết quả lên DataGridView
            dgvTraCuu.DataSource = ketQua;
        }

        private void TraCuuVanBang_Load(object sender, EventArgs e)
        {
            dgvTraCuu.DataSource = new List<chon_vanbangchinhthuc_Result>();
           

         
       
        }

     
    }
}
