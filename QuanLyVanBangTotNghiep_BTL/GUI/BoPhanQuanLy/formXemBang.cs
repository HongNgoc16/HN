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

namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    public partial class formXemBang : Form
    {
          private int idVB;
          private PhoiBang_BLL bll = new PhoiBang_BLL();
          public formXemBang(DataGridViewRow row)
        {
            InitializeComponent();
            idVB = Convert.ToInt32(row.Cells["Id_VanBang"].Value);
           textTen.Text = row.Cells["Ho_Va_Ten"].Value?.ToString();
            textNgaySinh.Text = Convert.ToDateTime(row.Cells["Ngay_Sinh"].Value).ToString("dd/MM/yyyy");
            textXepLoai.Text = row.Cells["Ten_XepLoai"].Value?.ToString();
            textSoHieuVB.Text = row.Cells["SoHieu"].Value?.ToString();
            textSoHieu.Text = row.Cells["SoHieuPhoi"].Value?.ToString();
            textNganhHoc.Text = row.Cells["Ten_Nganh"].Value?.ToString();
          
            
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

        private void formXemBang_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
