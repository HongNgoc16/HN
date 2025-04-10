using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyVanBangTotNghiep_BTL;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class ucNganhHoc : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public ucNganhHoc()
        {
            InitializeComponent();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaNganh.Clear();
            textTenNganh.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            textMaNganh.Focus();
            opt= 1;    
        }
        public void HienThiDuLieu()
        {
            dgNganhHoc.DataSource = db.chon_nganhhoc();
        }
     
       
      
        private void ucNganhHoc_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;
            if (opt == 1)
            {
                db.them_nganhhoc(textMaNganh.Text, textTenNganh.Text, trang_Thai_Su_Dung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Thêm ngành học thành công!");
            }
            
        }

        private void dgNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaNganh.Text= dgNganhHoc[1, dgNganhHoc.CurrentRow.Index].Value.ToString();
            textTenNganh.Text = dgNganhHoc[2, dgNganhHoc.CurrentRow.Index].Value.ToString();
            bool trang_Thai_Su_Dung = Convert.ToBoolean(dgNganhHoc[3, e.RowIndex].Value);
            rdbDangSd.Checked = trang_Thai_Su_Dung;    // Nếu trạng thái là true (1) -> Được sử dụng
            rdbKhongSd.Checked = !trang_Thai_Su_Dung;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgNganhHoc[0, dgNganhHoc.CurrentRow.Index].Value.ToString());
            
            DialogResult result = MessageBox.Show ("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.xoa_nganhhoc(id);
                HienThiDuLieu();
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgNganhHoc.CurrentRow != null)
            {
                bool trang_Thai_Su_Dung = rdbDangSd.Checked;


                int id = Convert.ToInt32(dgNganhHoc[0, dgNganhHoc.CurrentRow.Index].Value.ToString());
                db.sua_nganhhoc(id, textMaNganh.Text, textTenNganh.Text, trang_Thai_Su_Dung);
                opt = -1;
                HienThiDuLieu();
                MessageBox.Show("Sửa ngành học thành công!");
            }
        }

        private void buttonNganhHoc_Click(object sender, EventArgs e)
        {

        }
    }
}
