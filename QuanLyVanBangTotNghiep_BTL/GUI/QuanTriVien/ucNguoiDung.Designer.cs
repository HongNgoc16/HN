namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    partial class ucNguoiDung
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
            this.cboBoxLoaiND = new System.Windows.Forms.ComboBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.textTenDangNhap = new System.Windows.Forms.TextBox();
            this.textMaND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgNguoiDung = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNguoiDung)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 44);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(333, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH MỤC NGƯỜI DÙNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboBoxLoaiND);
            this.groupBox2.Controls.Add(this.textMatKhau);
            this.groupBox2.Controls.Add(this.textTenDangNhap);
            this.groupBox2.Controls.Add(this.textMaND);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(-13, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 138);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // cboBoxLoaiND
            // 
            this.cboBoxLoaiND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBoxLoaiND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBoxLoaiND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxLoaiND.FormattingEnabled = true;
            this.cboBoxLoaiND.Items.AddRange(new object[] {
            "qtv",
            "bpql",
            "bpd"});
            this.cboBoxLoaiND.Location = new System.Drawing.Point(598, 86);
            this.cboBoxLoaiND.Name = "cboBoxLoaiND";
            this.cboBoxLoaiND.Size = new System.Drawing.Size(292, 33);
            this.cboBoxLoaiND.TabIndex = 7;
            // 
            // textMatKhau
            // 
            this.textMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatKhau.Location = new System.Drawing.Point(156, 89);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(288, 31);
            this.textMatKhau.TabIndex = 6;
            // 
            // textTenDangNhap
            // 
            this.textTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDangNhap.Location = new System.Drawing.Point(598, 37);
            this.textTenDangNhap.Name = "textTenDangNhap";
            this.textTenDangNhap.Size = new System.Drawing.Size(292, 31);
            this.textTenDangNhap.TabIndex = 5;
            // 
            // textMaND
            // 
            this.textMaND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMaND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaND.Location = new System.Drawing.Point(156, 40);
            this.textMaND.Name = "textMaND";
            this.textMaND.Size = new System.Drawing.Size(288, 31);
            this.textMaND.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(450, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại người dùng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(450, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgNguoiDung);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(0, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 274);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // dgNguoiDung
            // 
            this.dgNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNguoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNguoiDung.Location = new System.Drawing.Point(3, 30);
            this.dgNguoiDung.Name = "dgNguoiDung";
            this.dgNguoiDung.RowHeadersWidth = 62;
            this.dgNguoiDung.RowTemplate.Height = 28;
            this.dgNguoiDung.Size = new System.Drawing.Size(929, 241);
            this.dgNguoiDung.TabIndex = 0;
            this.dgNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNguoiDung_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLuu);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.buttonThemMoi);
            this.panel2.Location = new System.Drawing.Point(25, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 45);
            this.panel2.TabIndex = 25;
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
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(474, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
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
            // ucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucNguoiDung";
            this.Size = new System.Drawing.Size(935, 557);
            this.Load += new System.EventHandler(this.ucNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNguoiDung)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboBoxLoaiND;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.TextBox textTenDangNhap;
        private System.Windows.Forms.TextBox textMaND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgNguoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThemMoi;
    }
}
