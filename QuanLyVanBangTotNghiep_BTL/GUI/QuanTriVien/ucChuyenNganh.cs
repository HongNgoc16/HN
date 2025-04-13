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
        private void LoadComboBox()
        {
            comboBoxTenNganh.DataSource = db.dm_NganhHoc.ToList();
            comboBoxTenNganh.DisplayMember = "Ten_Nganh";
            comboBoxTenNganh.ValueMember = "Id_NganhHoc";
        }

        private void ucChuyenNganh_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LoadComboBox();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaChuyenNganh.Clear();
            textTenChuyenNganh.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            comboBoxTenNganh.SelectedIndex = -1;
            textMaChuyenNganh.Focus();
            opt = 1;

        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string maCN = textMaChuyenNganh.Text;
            string tenCN = textTenChuyenNganh.Text;
            int idNganh = Convert.ToInt32(comboBoxTenNganh.SelectedValue);
            bool trangThai = rdbDangSd.Checked;

            db.them_chuyennganh(maCN, tenCN, idNganh, trangThai);

            MessageBox.Show("Thêm chuyên ngành thành công!");
            HienThiDuLieu();
            opt = -1;


        }

        private void dgChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgChuyenNganh.CurrentRow != null)
            {
                textMaChuyenNganh.Text = dgChuyenNganh[1, dgChuyenNganh.CurrentRow.Index].Value.ToString();
                textTenChuyenNganh.Text = dgChuyenNganh[2, dgChuyenNganh.CurrentRow.Index].Value.ToString();
                string tenNganh = dgChuyenNganh[3, dgChuyenNganh.CurrentRow.Index].Value.ToString(); 
                comboBoxTenNganh.Text = tenNganh;
                bool trangThai = Convert.ToBoolean(dgChuyenNganh[4, dgChuyenNganh.CurrentRow.Index].Value);
                rdbDangSd.Checked = trangThai;
                rdbKhongSd.Checked = !trangThai;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
          
                if (dgChuyenNganh.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgChuyenNganh[0, dgChuyenNganh.CurrentRow.Index].Value.ToString());
                    string maCN = textMaChuyenNganh.Text;
                    string tenCN = textTenChuyenNganh.Text;
                    int idNganh = Convert.ToInt32(comboBoxTenNganh.SelectedValue);
                    bool trangThai = rdbDangSd.Checked;

                    db.sua_chuyennganh(id, maCN, tenCN, idNganh, trangThai);
                    HienThiDuLieu();
                    MessageBox.Show("Sửa chuyên ngành thành công!");
                }
            }
   
    }
}
