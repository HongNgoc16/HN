using QuanLyVanBangTotNghiep_BTL.BLL;
using System;
using System.Windows.Forms;
namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    public partial class uc_DuyetVanBang : UserControl
    {
        VanBangTam_BLL vbtam = new VanBangTam_BLL();
        public uc_DuyetVanBang()
        {
            InitializeComponent();
        }
        private void AddCheckboxColumns()
        {
            if (!dgDuyet.Columns.Contains("colDuyet"))
            {
                var colDuyet = new DataGridViewCheckBoxColumn
                {
                    Name = "colDuyet",
                    HeaderText = "Duyêt",
                    Width = 50,

                };
                dgDuyet.Columns.Add(colDuyet);
            }
            if (!dgDuyet.Columns.Contains("colTuChoi"))
            {
                var colTuChoi = new DataGridViewCheckBoxColumn
                {
                    Name = "colTuChoi",
                    HeaderText = "Từ chối",
                    Width = 50,
                };
                dgDuyet.Columns.Add(colTuChoi);
             
            }
        }

        private void LoadDanhSachVanBang()
        {
            var danhSach = vbtam.GetChon_Vanbangtam_Results();
            dgDuyet.DataSource = danhSach;
             AddCheckboxColumns();
        }



        private void uc_DuyetVanBang_Load(object sender, EventArgs e)
        {
            cboBoxTrangThai.Items.AddRange(new string[] { "Tất cả", "Chờ duyệt", "Đã duyệt", "Từ chối" });
            cboBoxTrangThai.SelectedIndex = 0;
            LoadDanhSachVanBang();
        }

        private void buttonTimKiem_Click_1(object sender, EventArgs e)
        {
            string maSV = textMaSV.Text.Trim();
            string hoTen = textHoVaTen.Text.Trim();
            string nganhHoc = textNganhHoc.Text.Trim();
            string khoaHoc = textKhoaHoc.Text.Trim();
            int? trangThai = null;

            if (cboBoxTrangThai.SelectedIndex > 0)
            {
                trangThai = cboBoxTrangThai.SelectedIndex - 1;
            }

            var ketQua = vbtam.TimKiem(maSV, nganhHoc, "", trangThai);

            dgDuyet.DataSource = ketQua;
        }

        private void dgDuyet_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDuyet.Rows[e.RowIndex];
                formDuyetVanBang frm = new formDuyetVanBang(row);
                frm.OnCapNhatThanhCong = () =>
                {
                    LoadDanhSachVanBang();
                };
                frm.ShowDialog();
            }

        }

        private void dgDuyet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var grid = dgDuyet;
            var columnName = grid.Columns[e.ColumnIndex].Name;
            var row = grid.Rows[e.RowIndex];
            string trangThai = row.Cells["Trang_Thai"].Value?.ToString();

            if (trangThai!="Chờ duyệt"){
                MessageBox.Show("Dòng này đã được xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (columnName == "colDuyet")
            {
                bool check = Convert.ToBoolean(row.Cells["colDuyet"].Value ?? false);
                bool applyAll = false;
                if (dgDuyet.SelectedRows.Count > 1) {
                    var rs = MessageBox.Show("Bạn có muốn duyệt tất cả không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        applyAll = true;
                    }
                }
                if (applyAll)
                {
                    foreach (DataGridViewRow selectedRow in dgDuyet.SelectedRows)
                    {
                        string tt = selectedRow.Cells["Trang_Thai"].Value?.ToString();
                        if (tt == "Chờ duyệt")
                        {
                            selectedRow.Cells["colDuyet"].Value = true;
                            selectedRow.Cells["colTuChoi"].Value = false;
                        }
                    }    
                }
                else
                {
                    row.Cells["colDuyet"].Value =! check;
                    if ((bool)row.Cells["colDuyet"].Value==true)
                    {
                        row.Cells["colTuChoi"].Value=false;
                    }
                }
              
            }
            if (columnName == "colTuChoi")
            {
                bool check = Convert.ToBoolean(row.Cells["colTuChoi"].Value ?? false);
                bool applyAll = false;
                if (dgDuyet.SelectedRows.Count > 1)
                {
                    var rs = MessageBox.Show("Bạn có muốn từ chối tất cả không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        applyAll = true;

                    }

                }
                if (applyAll)
                {
                    foreach (DataGridViewRow selectedRow in dgDuyet.SelectedRows)
                    {
                        string tt = selectedRow.Cells["Trang_Thai"].Value?.ToString();
                        if (tt == "Chờ duyệt")
                        {
                            selectedRow.Cells["colTuChoi"].Value = true;
                            selectedRow.Cells["colDuyet"].Value = false;
                        }
                    }
                }
                else
                {
                    row.Cells["colTuChoi"].Value = !check;
                    if ((bool)row.Cells["colTuChoi"].Value == true)
                        row.Cells["colDuyet"].Value = false;
                }
            }

        }
    }
}
