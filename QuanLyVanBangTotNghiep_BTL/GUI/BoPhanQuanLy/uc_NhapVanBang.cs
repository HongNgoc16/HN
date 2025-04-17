using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Mask.Design;
using QuanLyVanBangTotNghiep_BTL.BLL;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    public partial class uc_NhapVanBang : UserControl
    {
        private VanBangCT_BLL bll = new VanBangCT_BLL();
        private int opt = -1;
        public uc_NhapVanBang()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgVanBang.DataSource = bll.chon_Vanbangchinhthuc_Results();
        }

        private void uc_NhapVanBang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cboBoxTrangThai.Items.AddRange(new string[] { "Tất cả", "Chưa cấp", "Đã cấp", "Đã hủy" });
            cboBoxTrangThai.SelectedIndex = 0;

        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
           formThemVanBang form = new formThemVanBang();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

      


        private void dgVanBang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVanBang.Rows[e.RowIndex];

                string trangThai = row.Cells["TrangThai"].Value.ToString();

                if (trangThai == "Chưa cấp")
                {
                    formCapBang frm = new formCapBang(row);
                    frm.OnCapNhatThanhCong = () =>
                    {
                        HienThiDuLieu();
                    };
                    frm.ShowDialog();
                }
                else if (trangThai == "Đã cấp")
                {
                    formXemBang frm = new formXemBang(row); 
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Trạng thái không hợp lệ hoặc không hỗ trợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string maSinhVien = textMaSV.Text.Trim();
            string hoVaTen = textHoVaTen.Text.Trim();
            string tenNganh = textNganhHoc.Text.Trim();
            string khoaHoc = textKhoaHoc.Text.Trim();
            string xepLoai = textXepLoai.Text.Trim();
            int? trangThai = null;
            if (cboBoxTrangThai.SelectedIndex > 0)
            {
                trangThai = cboBoxTrangThai.SelectedIndex - 1; 
            }

            var ketQua = bll.TimKiemVanBang(maSinhVien, tenNganh, hoVaTen, null, xepLoai, trangThai);


            dgVanBang.DataSource = ketQua;
        }
    }
    
}
