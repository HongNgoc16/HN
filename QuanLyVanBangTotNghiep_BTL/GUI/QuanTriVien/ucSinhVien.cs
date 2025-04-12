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
        QLVB_Entities db = new QLVB_Entities();
        private dm_SinhVien_BLL bll = new dm_SinhVien_BLL();
        int opt = -1;
        public ucSinhVien()
        {
            InitializeComponent();
        }
        private void LoadComboboxes()
        {
            comboBoxChuyenNganh.DataSource = db.dm_ChuyenNganh.Where(c => c.Trang_Thai_Su_Dung == true).ToList();
            comboBoxChuyenNganh.DisplayMember = "Ten_ChuyenNganh";
            comboBoxChuyenNganh.ValueMember = "Id_ChuyenNganh";

            comboBoxKhoaHoc.DataSource = db.dm_KhoaHoc.Where(k => k.Trang_Thai == true).ToList();
            comboBoxKhoaHoc.DisplayMember = "Ma_KhoaHoc";
            comboBoxKhoaHoc.ValueMember = "Id_KhoaHoc";

            comboBoxDVQL.DataSource = db.dm_DonViQuanLy.Where(d => d.Trang_Thai_Su_Dung == true).ToList();
            comboBoxDVQL.DisplayMember = "Ten_DonViQuanLy";
            comboBoxDVQL.ValueMember = "Id_DonViQuanLy";

            comboBoxXepLoai.DataSource = db.dm_XepLoai.Where(x => x.Trang_Thai_Su_Dung == true).ToList();
            comboBoxXepLoai.DisplayMember = "Ten_XepLoai"; 
            comboBoxXepLoai.ValueMember = "Id_XepLoai";
        }
            private void HienThiDuLieu()
        {
            dgSinhVien.DataSource = bll.GetChon_Sinhvien_Results();
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaSV.Clear();
            textHoVaTen.Clear();
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateNgaySinh.Value = DateTime.Now;
            comboBoxChuyenNganh.SelectedIndex = -1;
            textSoDienThoai.Clear();
            textEmail.Clear();
            textDiemTB.Clear();
            comboBoxKhoaHoc.SelectedIndex = -1;
            comboBoxDVQL.SelectedIndex = -1;
            comboBoxXepLoai.SelectedIndex = -1;
            radioButtonDaTN.Checked = false;
            radioButtonChuaTN.Checked = false;

            opt = 1; 
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LoadComboboxes();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
