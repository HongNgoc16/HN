namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    partial class ucChuyenNganh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbKhongSd = new System.Windows.Forms.RadioButton();
            this.rdbDangSd = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.textMaChuyenNganh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgChuyenNganh = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonNganhHoc = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.comboBoxTenNganh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChuyenNganh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 44);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(279, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH MỤC CHUYÊN NGÀNH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTenNganh);
            this.groupBox2.Controls.Add(this.rdbKhongSd);
            this.groupBox2.Controls.Add(this.rdbDangSd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textTenChuyenNganh);
            this.groupBox2.Controls.Add(this.textMaChuyenNganh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(3, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 223);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // rdbKhongSd
            // 
            this.rdbKhongSd.AutoSize = true;
            this.rdbKhongSd.ForeColor = System.Drawing.Color.Black;
            this.rdbKhongSd.Location = new System.Drawing.Point(385, 174);
            this.rdbKhongSd.Name = "rdbKhongSd";
            this.rdbKhongSd.Size = new System.Drawing.Size(155, 29);
            this.rdbKhongSd.TabIndex = 10;
            this.rdbKhongSd.TabStop = true;
            this.rdbKhongSd.Text = "Không sử dụng";
            this.rdbKhongSd.UseVisualStyleBackColor = true;
            // 
            // rdbDangSd
            // 
            this.rdbDangSd.AutoSize = true;
            this.rdbDangSd.ForeColor = System.Drawing.Color.Black;
            this.rdbDangSd.Location = new System.Drawing.Point(218, 172);
            this.rdbDangSd.Name = "rdbDangSd";
            this.rdbDangSd.Size = new System.Drawing.Size(147, 29);
            this.rdbDangSd.TabIndex = 9;
            this.rdbDangSd.TabStop = true;
            this.rdbDangSd.Text = "Đang sử dụng";
            this.rdbDangSd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(20, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trạng thái sử dụng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTenChuyenNganh
            // 
            this.textTenChuyenNganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTenChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenChuyenNganh.Location = new System.Drawing.Point(218, 84);
            this.textTenChuyenNganh.Name = "textTenChuyenNganh";
            this.textTenChuyenNganh.Size = new System.Drawing.Size(322, 31);
            this.textTenChuyenNganh.TabIndex = 5;
            // 
            // textMaChuyenNganh
            // 
            this.textMaChuyenNganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMaChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaChuyenNganh.Location = new System.Drawing.Point(218, 40);
            this.textMaChuyenNganh.Name = "textMaChuyenNganh";
            this.textMaChuyenNganh.Size = new System.Drawing.Size(322, 31);
            this.textMaChuyenNganh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên ngành:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên chuyên ngành:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyên ngành:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgChuyenNganh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(0, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 277);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dgChuyenNganh
            // 
            this.dgChuyenNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChuyenNganh.Location = new System.Drawing.Point(3, 27);
            this.dgChuyenNganh.Name = "dgChuyenNganh";
            this.dgChuyenNganh.RowHeadersWidth = 62;
            this.dgChuyenNganh.RowTemplate.Height = 28;
            this.dgChuyenNganh.Size = new System.Drawing.Size(889, 247);
            this.dgChuyenNganh.TabIndex = 0;
            this.dgChuyenNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChuyenNganh_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLuu);
            this.panel2.Controls.Add(this.buttonNganhHoc);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.buttonThemMoi);
            this.panel2.Location = new System.Drawing.Point(21, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 45);
            this.panel2.TabIndex = 24;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLuu.FlatAppearance.BorderSize = 0;
            this.buttonLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLuu.ForeColor = System.Drawing.Color.White;
            this.buttonLuu.Location = new System.Drawing.Point(602, 3);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(107, 35);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonNganhHoc
            // 
            this.buttonNganhHoc.AutoSize = true;
            this.buttonNganhHoc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNganhHoc.FlatAppearance.BorderSize = 0;
            this.buttonNganhHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonNganhHoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonNganhHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNganhHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonNganhHoc.ForeColor = System.Drawing.Color.White;
            this.buttonNganhHoc.Location = new System.Drawing.Point(474, 3);
            this.buttonNganhHoc.Name = "buttonNganhHoc";
            this.buttonNganhHoc.Size = new System.Drawing.Size(107, 35);
            this.buttonNganhHoc.TabIndex = 4;
            this.buttonNganhHoc.Text = "Tìm kiếm";
            this.buttonNganhHoc.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(346, 3);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(107, 35);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(218, 3);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(107, 35);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.AutoSize = true;
            this.buttonThemMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonThemMoi.FlatAppearance.BorderSize = 0;
            this.buttonThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonThemMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonThemMoi.ForeColor = System.Drawing.Color.White;
            this.buttonThemMoi.Location = new System.Drawing.Point(96, 3);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(107, 35);
            this.buttonThemMoi.TabIndex = 1;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = false;
            this.buttonThemMoi.Click += new System.EventHandler(this.buttonThemMoi_Click);
            // 
            // comboBoxTenNganh
            // 
            this.comboBoxTenNganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTenNganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTenNganh.FormattingEnabled = true;
            this.comboBoxTenNganh.Location = new System.Drawing.Point(218, 124);
            this.comboBoxTenNganh.Name = "comboBoxTenNganh";
            this.comboBoxTenNganh.Size = new System.Drawing.Size(322, 33);
            this.comboBoxTenNganh.TabIndex = 11;
            // 
            // ucChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucChuyenNganh";
            this.Size = new System.Drawing.Size(895, 616);
            this.Load += new System.EventHandler(this.ucChuyenNganh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChuyenNganh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbKhongSd;
        private System.Windows.Forms.RadioButton rdbDangSd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTenChuyenNganh;
        private System.Windows.Forms.TextBox textMaChuyenNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgChuyenNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonNganhHoc;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.ComboBox comboBoxTenNganh;
    }
}
