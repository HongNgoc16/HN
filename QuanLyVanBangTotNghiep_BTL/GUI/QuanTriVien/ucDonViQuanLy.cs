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
    public partial class ucDonViQuanLy : UserControl
    {
        int opt = -1;
        private dm_DonViQuanLy_BLL bll = new dm_DonViQuanLy_BLL();
        public ucDonViQuanLy()
        {
            InitializeComponent();
        }
        private void HienThiDuLieu()
        {
            dgDonViQuanLy.DataSource = bll.GetChon_Donviquanly_Results();
        }
        private void ucDonViQuanLy_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            //dgDonViQuanLy.CellFormatting += dgDonViQuanLy_CellFormatting;
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            textMaDVQL.Clear();
            textTenDVQL.Clear();
            textTenDVQLCha.Clear();
            rdbDangSd.Checked = false;
            rdbKhongSd.Checked = false;
            textMaDVQL.Focus();
            opt = 1;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dgDonViQuanLy.CurrentRow != null)
            {
                bool trang_Thai_Su_Dung = rdbDangSd.Checked;
                int id = Convert.ToInt32(dgDonViQuanLy[0, dgDonViQuanLy.CurrentRow.Index].Value.ToString());
                bll.SuaDonViQuanLy(id, textMaDVQL.Text, textTenDVQL.Text, textTenDVQLCha.Text, trang_Thai_Su_Dung);
                HienThiDuLieu();
                MessageBox.Show("Sửa đơn vị quản lý thành công!");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgDonViQuanLy.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgDonViQuanLy[0, dgDonViQuanLy.CurrentRow.Index].Value.ToString());
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bll.XoaDonViQuanLy(id);
                    HienThiDuLieu();
                    MessageBox.Show("Xóa đơn vị quản lý thành công!");

                }
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            bool trang_Thai_Su_Dung = rdbDangSd.Checked;
            if (opt == 1)
            {
                bll.ThemDonViQuanLy(textMaDVQL.Text, textTenDVQL.Text, textTenDVQLCha.Text, trang_Thai_Su_Dung);
                HienThiDuLieu();
                MessageBox.Show("Thêm đơn vị quản lý thành công!");
                opt = -1;
            }
        }

        private void dgDonViQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaDVQL.Text = dgDonViQuanLy[1, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            textTenDVQL.Text = dgDonViQuanLy[2, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            textTenDVQLCha.Text = dgDonViQuanLy[3, dgDonViQuanLy.CurrentRow.Index].Value.ToString();
            bool trang_Thai_Su_Dung = Convert.ToBoolean(dgDonViQuanLy[4, e.RowIndex].Value);
            rdbDangSd.Checked = trang_Thai_Su_Dung;
            rdbKhongSd.Checked = !trang_Thai_Su_Dung;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string maDVQL = textMaDVQL.Text.Trim();
            string tenDVQL = textTenDVQL.Text.Trim();
            string tenDVQLCha = textTenDVQLCha.Text.Trim();

            bool locTheoTrangThai = rdbDangSd.Checked || rdbKhongSd.Checked;
            bool? trangThaiSuDung = null;

            // Xác định trạng thái cần tìm
            if (rdbDangSd.Checked)
            {
                trangThaiSuDung = true;
            }
            else if (rdbKhongSd.Checked)
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

                    dgDonViQuanLy.DataSource = dt;

                    // Định dạng DataGridView
                    dgDonViQuanLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgDonViQuanLy.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                }
                else
                {
                    dgDonViQuanLy.DataSource = null;
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
