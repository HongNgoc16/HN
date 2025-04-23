using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyVanBangTotNghiep_BTL.BLL;

namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class UcDonViQuanLy : UserControl
    {
        int opt = -1;
        private dm_DonViQuanLy_BLL bll = new dm_DonViQuanLy_BLL();
        public UcDonViQuanLy()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgvDonViQuanLy.DataSource = bll.GetChon_Donviquanly_Results();
        }
        private void UcDonViQuanLy_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            //dgDonViQuanLy.CellFormatting += dgDonViQuanLy_CellFormatting;
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaDVQL.Clear();
            txtTenDVQL.Clear();
            txtTenDVQLCha.Clear();
            rdoDangSuDung.Checked = false;
            rdoKhongSuDung.Checked = false;
            txtMaDVQL.Focus();
            opt = 1;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvDonViQuanLy.CurrentRow != null)
            {
                bool trangThaiSuDung = rdoDangSuDung.Checked;
                int id = Convert.ToInt32(dgvDonViQuanLy[0, dgvDonViQuanLy.CurrentRow.Index].Value.ToString());
                bll.SuaDonViQuanLy(id, txtMaDVQL.Text, txtTenDVQL.Text, txtTenDVQLCha.Text, trangThaiSuDung);
                HienThiDuLieu();
                MessageBox.Show("Sửa đơn vị quản lý thành công!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonViQuanLy.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDonViQuanLy[0, dgvDonViQuanLy.CurrentRow.Index].Value.ToString());
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.XoaDonViQuanLy(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa đơn vị quản lý thành công!");

                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bool trangThaiSuDung = rdoDangSuDung.Checked;
            if (opt == 1)
            {
                bll.ThemDonViQuanLy(txtMaDVQL.Text, txtTenDVQL.Text, txtTenDVQLCha.Text, trangThaiSuDung);
                HienThiDuLieu();
                MessageBox.Show("Thêm đơn vị quản lý thành công!");
                opt = -1;
            }
        }

        private void DgvDonViQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDVQL.Text = dgvDonViQuanLy[1, dgvDonViQuanLy.CurrentRow.Index].Value.ToString();
            txtTenDVQL.Text = dgvDonViQuanLy[2, dgvDonViQuanLy.CurrentRow.Index].Value.ToString();
            txtTenDVQLCha.Text = dgvDonViQuanLy[3, dgvDonViQuanLy.CurrentRow.Index].Value.ToString();
            bool trang_Thai_Su_Dung = Convert.ToBoolean(dgvDonViQuanLy[4, e.RowIndex].Value);
            rdoDangSuDung.Checked = trang_Thai_Su_Dung;
            rdoKhongSuDung.Checked = !trang_Thai_Su_Dung;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string maDVQL = txtMaDVQL.Text.Trim();
            string tenDVQL = txtTenDVQL.Text.Trim();
            string tenDVQLCha = txtTenDVQLCha.Text.Trim();

            bool locTheoTrangThai = rdoDangSuDung.Checked || rdoKhongSuDung.Checked;
            bool? trangThaiSuDung = null;

            // Xác định trạng thái cần tìm
            if (rdoDangSuDung.Checked)
            {
                trangThaiSuDung = true;
            }
            else if (rdoKhongSuDung.Checked)
            {
                trangThaiSuDung = false;
            }

            // Kiểm tra điều kiện rỗng
            if (string.IsNullOrEmpty(maDVQL) &&
                string.IsNullOrEmpty(tenDVQL) &&
                string.IsNullOrEmpty(tenDVQLCha) &&
                !locTheoTrangThai)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để tìm kiếm!",
                              "Thông báo",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy dữ liệu từ BLL
                var danhSachDonVi = bll.GetChon_Donviquanly_Results();

                // Thực hiện tìm kiếm
                var ketQuaTimKiem = danhSachDonVi
                    .Where(dv =>
                        (string.IsNullOrEmpty(maDVQL) || dv.Ma_DonViQuanLy.Equals(maDVQL, StringComparison.OrdinalIgnoreCase)) &&
                        (string.IsNullOrEmpty(tenDVQL) || (dv.Ten_DonViQuanLy != null &&
                         dv.Ten_DonViQuanLy.IndexOf(tenDVQL, StringComparison.OrdinalIgnoreCase) >= 0)) &&
                        (string.IsNullOrEmpty(tenDVQLCha) || (dv.Ten_DonViQuanLy_Cha != null &&
                         dv.Ten_DonViQuanLy_Cha.IndexOf(tenDVQLCha, StringComparison.OrdinalIgnoreCase) >= 0)) &&
                        (!locTheoTrangThai || (trangThaiSuDung.HasValue && dv.Trang_Thai_Su_Dung == trangThaiSuDung.Value))
                    )
                    .ToList();

                // Hiển thị kết quả
                if (ketQuaTimKiem.Any())
                {
                    // Tạo DataTable để định dạng đẹp hơn
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã đơn vị", typeof(string));
                    dt.Columns.Add("Tên đơn vị", typeof(string));
                    dt.Columns.Add("Tên đơn vị cha", typeof(string));
                    dt.Columns.Add("Trạng thái", typeof(string));

                    foreach (var item in ketQuaTimKiem)
                    {
                        dt.Rows.Add(
                            item.Ma_DonViQuanLy,
                            item.Ten_DonViQuanLy,
                            item.Ten_DonViQuanLy_Cha,
                          item.Trang_Thai_Su_Dung.HasValue
            ? (item.Trang_Thai_Su_Dung.Value ? "Đang sử dụng" : "Không sử dụng")
            : "Không xác định"
    );
                    }

                    dgvDonViQuanLy.DataSource = dt;

                    // Định dạng DataGridView
                    dgvDonViQuanLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDonViQuanLy.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                }
                else
                {
                    dgvDonViQuanLy.DataSource = null;
                    MessageBox.Show("Không tìm thấy đơn vị quản lý nào phù hợp!",
                                  "Thông báo",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện tìm kiếm: " + ex.Message,
                              "Lỗi",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

            }
        }
    }
}
