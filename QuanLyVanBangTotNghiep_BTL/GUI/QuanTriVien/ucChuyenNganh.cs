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

        private void buttonNganhHoc_Click(object sender, EventArgs e)
        {
            string maChuyenNganh = textMaChuyenNganh.Text.Trim();
            string tenChuyenNganh = textTenChuyenNganh.Text.Trim();
            string selectedNganh = comboBoxTenNganh.Text.Trim(); // Sửa lại chỗ này, dùng Text thay vì SelectedValue

            bool locTheoTrangThai = rdbDangSd.Checked || rdbKhongSd.Checked;
            bool? trangThaiSuDung = null;

            if (rdbDangSd.Checked)
            {
                trangThaiSuDung = true;
            }
            else if (rdbKhongSd.Checked)
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

                    dgChuyenNganh.DataSource = dt;

                    // Định dạng cột
                    dgChuyenNganh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgChuyenNganh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                }
                else
                {
                    dgChuyenNganh.DataSource = null;
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
