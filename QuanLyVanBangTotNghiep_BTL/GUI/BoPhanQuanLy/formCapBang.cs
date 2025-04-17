using QuanLyVanBangTotNghiep_BTL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    public partial class formCapBang : Form
    {
        
        private int idVB;
        private PhoiBang_BLL bll = new PhoiBang_BLL();
        public formCapBang(DataGridViewRow row)
        {
            InitializeComponent();
            idVB     = Convert.ToInt32(row.Cells["Id_VanBang"].Value);

            comboBoxDotCap.Text = row.Cells["Ten_Dot_Cap"].Value?.ToString();
            textMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
            textHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();
            dateTimeNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
            textNganhHoc.Text = row.Cells["Ten_Nganh"].Value?.ToString();
            textChuyenNganh.Text = row.Cells["Ten_ChuyenNganh"].Value?.ToString();
            textKhoaHoc.Text = row.Cells["Ma_KhoaHoc"].Value?.ToString();
            textXepLoai.Text = row.Cells["Ten_XepLoai"].Value?.ToString();
            textSHVB.Text = row.Cells["SoHieu"].Value?.ToString();
            dateTimeNgayCap.Value = Convert.ToDateTime(row.Cells["Ngay_Cap"].Value);
            textNoiCap.Text = row.Cells["Noi_Cap"].Value?.ToString();


        }
        public Action OnCapNhatThanhCong { get; set; }
        private void formCapBang_Load(object sender, EventArgs e)
        {
            PhoiBang_BLL phoiBLL = new PhoiBang_BLL();
            var danhSachPhoi = phoiBLL.LayPhoiChuaCap();

            cboBoxSoHieuPhoi.DataSource = danhSachPhoi;
            cboBoxSoHieuPhoi.DisplayMember = "SoHieuPhoi";
            cboBoxSoHieuPhoi.ValueMember = "Id_PhoiBang";

        }

        private void buttonCapBang_Click(object sender, EventArgs e)
        {
            int idPhoiBang = Convert.ToInt32(cboBoxSoHieuPhoi.SelectedValue);

            var vbBLL = new VanBangCT_BLL();
            var phoiBLL = new PhoiBang_BLL();

            // Cập nhật văn bằng: trạng thái = 1 (Đã cấp), gán Id_PhoiBang, Ngày_Cấp
            vbBLL.CapNhatTrangThaiVanBang(idVB, idPhoiBang);

            // Cập nhật trạng thái phôi: đã cấp
            phoiBLL.CapNhatTrangThaiPhoi(idPhoiBang);

            MessageBox.Show("Cấp bằng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OnCapNhatThanhCong?.Invoke(); // gọi form cha reload
            this.Close();
        }
    }
}
