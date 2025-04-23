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

    
    public partial class UcChuyenNganh : UserControl
    {
        int opt = -1;
        QLVB_Entities db = new QLVB_Entities();
        public UcChuyenNganh()
        {
            InitializeComponent();
        }
        public void HienThiDuLieu()
        {
            dgvChuyenNganh.DataSource = db.chon_chuyennganh();
        }
        private void LoadComboBox()
        {
            cboTenNganh.DataSource = db.dm_NganhHoc.ToList();
            cboTenNganh.DisplayMember = "Ten_Nganh";
            cboTenNganh.ValueMember = "Id_NganhHoc";
        }

        private void UcChuyenNganh_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LoadComboBox();
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaChuyenNganh.Clear();
            txtTenChuyenNganh.Clear();
            rdoDangSuDung.Checked = false;
            rdoKhongSuDung.Checked = false;
            cboTenNganh.SelectedIndex = -1;
            txtMaChuyenNganh.Focus();
            opt = 1;

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string maCN = txtMaChuyenNganh.Text;
            string tenCN = txtTenChuyenNganh.Text;
            int idNganh = Convert.ToInt32(cboTenNganh.SelectedValue);
            bool trangThai = rdoDangSuDung.Checked;

            db.them_chuyennganh(maCN, tenCN, idNganh, trangThai);

            MessageBox.Show("Thêm chuyên ngành thành công!");
            HienThiDuLieu();
            opt = -1;


        }

        private void DgvChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChuyenNganh.CurrentRow != null)
            {
                txtMaChuyenNganh.Text = dgvChuyenNganh[1, dgvChuyenNganh.CurrentRow.Index].Value.ToString();
                txtTenChuyenNganh.Text = dgvChuyenNganh[2, dgvChuyenNganh.CurrentRow.Index].Value.ToString();
                string tenNganh = dgvChuyenNganh[3, dgvChuyenNganh.CurrentRow.Index].Value.ToString(); 
                cboTenNganh.Text = tenNganh;
                bool trangThai = Convert.ToBoolean(dgvChuyenNganh[4, dgvChuyenNganh.CurrentRow.Index].Value);
                rdoDangSuDung.Checked = trangThai;
                rdoKhongSuDung.Checked = !trangThai;
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
          
                if (dgvChuyenNganh.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvChuyenNganh[0, dgvChuyenNganh.CurrentRow.Index].Value.ToString());
                    string maCN = txtMaChuyenNganh.Text;
                    string tenCN = txtTenChuyenNganh.Text;
                    int idNganh = Convert.ToInt32(cboTenNganh.SelectedValue);
                    bool trangThai = rdoDangSuDung.Checked;

                    db.sua_chuyennganh(id, maCN, tenCN, idNganh, trangThai);
                    HienThiDuLieu();
                    MessageBox.Show("Sửa chuyên ngành thành công!");
                }
            }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string maChuyenNganh = txtMaChuyenNganh.Text.Trim();
            string tenChuyenNganh = txtTenChuyenNganh.Text.Trim();
            string selectedNganh = cboTenNganh.Text.Trim(); // Sửa lại chỗ này, dùng Text thay vì SelectedValue

            bool locTheoTrangThai = rdoDangSuDung.Checked || rdoKhongSuDung.Checked;
            bool? trangThaiSuDung = null;

            if (rdoDangSuDung.Checked)
            {
                trangThaiSuDung = true;
            }
            else if (rdoKhongSuDung.Checked)
            {
                trangThaiSuDung = false;
            }

            // Kiểm tra nếu không nhập gì cả
            if (string.IsNullOrEmpty(maChuyenNganh) &&
                string.IsNullOrEmpty(tenChuyenNganh) &&
                string.IsNullOrEmpty(selectedNganh) &&
                !locTheoTrangThai)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi stored procedure
                var danhSachChuyenNganh = db.chon_chuyennganh().AsEnumerable();

                var ketQuaTimKiem = danhSachChuyenNganh.Where(cn =>
                    (string.IsNullOrEmpty(maChuyenNganh) || cn.Ma_ChuyenNganh.Equals(maChuyenNganh, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(tenChuyenNganh) || (cn.Ten_ChuyenNganh != null && cn.Ten_ChuyenNganh.IndexOf(tenChuyenNganh, StringComparison.OrdinalIgnoreCase) >= 0)) &&
                    (string.IsNullOrEmpty(selectedNganh) || (cn.Ten_Nganh != null && cn.Ten_Nganh.Equals(selectedNganh, StringComparison.OrdinalIgnoreCase))) &&
                    (!locTheoTrangThai || (trangThaiSuDung.HasValue && cn.Trang_Thai_Su_Dung == trangThaiSuDung.Value))
                ).ToList();

                if (ketQuaTimKiem.Count > 0)
                {
                    // Tạo DataTable để binding và định dạng
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Mã chuyên ngành", typeof(string));
                    dt.Columns.Add("Tên chuyên ngành", typeof(string));
                    dt.Columns.Add("Tên ngành", typeof(string));
                    dt.Columns.Add("Trạng thái", typeof(string));

                    foreach (var item in ketQuaTimKiem)
                    {
                        dt.Rows.Add(
                            item.Ma_ChuyenNganh,
                            item.Ten_ChuyenNganh,
                            item.Ten_Nganh,
                            item.Trang_Thai_Su_Dung ? "Đang sử dụng" : "Không sử dụng"
                        );
                    }

                    dgvChuyenNganh.DataSource = dt;

                    // Định dạng cột
                    dgvChuyenNganh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvChuyenNganh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                }
                else
                {
                    dgvChuyenNganh.DataSource = null;
                    MessageBox.Show("Không tìm thấy chuyên ngành nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
