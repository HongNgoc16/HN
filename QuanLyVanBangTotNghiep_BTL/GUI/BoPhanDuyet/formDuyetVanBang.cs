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
    public partial class formDuyetVanBang : Form
    {
        private int _idVanBang;
        private VanBangTam_BLL bll = new VanBangTam_BLL();

        public formDuyetVanBang(DataGridViewRow row)
        {
            
            InitializeComponent();
            _idVanBang = Convert.ToInt32(row.Cells["Id_VanBang"].Value);


            comboBoxDotCap.Text = row.Cells["Ten_Dot_Cap"].Value?.ToString();
            textMaSV.Text = row.Cells["Ma_SinhVien"].Value?.ToString();
            textHoVaTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();
            dateTimeNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value);
            textNganhHoc.Text = row.Cells["Ten_Nganh"].Value?.ToString();
            textChuyenNganh.Text = row.Cells["Ten_ChuyenNganh"].Value?.ToString();
            textKhoaHoc.Text = row.Cells["Ma_KhoaHoc"].Value?.ToString();
            textXepLoai.Text = row.Cells["Ten_XepLoai"].Value?.ToString();
            textSHVB.Text = row.Cells["So_Hieu_Van_Bang"].Value?.ToString();
            dateTimeNgayCap.Value = Convert.ToDateTime(row.Cells["Ngay_Cap"].Value);
            textNoiCap.Text = row.Cells["Noi_Cap"].Value?.ToString();
            string trangThaiStr = row.Cells["Trang_Thai"].Value?.ToString();
            if (trangThaiStr == "Đã duyệt" || trangThaiStr == "Từ chối")
            {
                buttonDuyet.Enabled = false;
                buttonTuChoi.Enabled = false;
            }
        }
        public Action OnCapNhatThanhCong { get; set; }

        private void formDuyetVanBang_Load(object sender, EventArgs e)
        {
           

        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            VanBangTam_BLL bll = new VanBangTam_BLL();
            bll.CapNhatTrangThai(_idVanBang, 1); // 1 = Đã duyệt

            MessageBox.Show("Duyệt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OnCapNhatThanhCong?.Invoke();

            // Chuyển duyệt văn bằng
           
            bll.ChuyenDuyetVanBang(_idVanBang);

           
        
             this.Close();
        }

        private void buttonTuChoi_Click(object sender, EventArgs e)
        {
            VanBangTam_BLL bll = new VanBangTam_BLL();
            bll.CapNhatTrangThai(_idVanBang, 2); // 2 = Từ chối

            MessageBox.Show("Từ chối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OnCapNhatThanhCong?.Invoke(); // ← gọi về form cha
            this.Close();
        }
    }
}
