namespace QuanLyVanBangTotNghiep_BTL.GUI.BoPhanQuanLy
{
    partial class uc_NhapVanBang
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
            this.buttonThemMoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgVanBang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textXepLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.cboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.textKhoaHoc = new System.Windows.Forms.TextBox();
            this.textNganhHoc = new System.Windows.Forms.TextBox();
            this.textHoVaTen = new System.Windows.Forms.TextBox();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVanBang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThemMoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 52);
            this.panel1.TabIndex = 0;
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Location = new System.Drawing.Point(740, 12);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(93, 34);
            this.buttonThemMoi.TabIndex = 3;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.buttonThemMoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(920, 12);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 34);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgVanBang);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 493);
            this.panel2.TabIndex = 2;
            // 
            // dgVanBang
            // 
            this.dgVanBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVanBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVanBang.Location = new System.Drawing.Point(313, 0);
            this.dgVanBang.Name = "dgVanBang";
            this.dgVanBang.RowHeadersWidth = 62;
            this.dgVanBang.RowTemplate.Height = 28;
            this.dgVanBang.Size = new System.Drawing.Size(727, 493);
            this.dgVanBang.TabIndex = 28;
            this.dgVanBang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVanBang_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textXepLoai);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonTimKiem);
            this.panel3.Controls.Add(this.cboBoxTrangThai);
            this.panel3.Controls.Add(this.textKhoaHoc);
            this.panel3.Controls.Add(this.textNganhHoc);
            this.panel3.Controls.Add(this.textHoVaTen);
            this.panel3.Controls.Add(this.textMaSV);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 493);
            this.panel3.TabIndex = 27;
            // 
            // textXepLoai
            // 
            this.textXepLoai.Location = new System.Drawing.Point(132, 187);
            this.textXepLoai.Name = "textXepLoai";
            this.textXepLoai.Size = new System.Drawing.Size(160, 26);
            this.textXepLoai.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Xếp loại";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(96, 285);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(88, 36);
            this.buttonTimKiem.TabIndex = 19;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // cboBoxTrangThai
            // 
            this.cboBoxTrangThai.FormattingEnabled = true;
            this.cboBoxTrangThai.Location = new System.Drawing.Point(131, 227);
            this.cboBoxTrangThai.Name = "cboBoxTrangThai";
            this.cboBoxTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cboBoxTrangThai.TabIndex = 9;
            // 
            // textKhoaHoc
            // 
            this.textKhoaHoc.Location = new System.Drawing.Point(131, 145);
            this.textKhoaHoc.Name = "textKhoaHoc";
            this.textKhoaHoc.Size = new System.Drawing.Size(160, 26);
            this.textKhoaHoc.TabIndex = 18;
            // 
            // textNganhHoc
            // 
            this.textNganhHoc.Location = new System.Drawing.Point(131, 106);
            this.textNganhHoc.Name = "textNganhHoc";
            this.textNganhHoc.Size = new System.Drawing.Size(160, 26);
            this.textNganhHoc.TabIndex = 17;
            // 
            // textHoVaTen
            // 
            this.textHoVaTen.Location = new System.Drawing.Point(131, 71);
            this.textHoVaTen.Name = "textHoVaTen";
            this.textHoVaTen.Size = new System.Drawing.Size(160, 26);
            this.textHoVaTen.TabIndex = 16;
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(131, 38);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(160, 26);
            this.textMaSV.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Khóa học";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Ngành học";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Họ và tên";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Mã sinh viên";
            // 
            // uc_NhapVanBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_NhapVanBang";
            this.Size = new System.Drawing.Size(1040, 545);
            this.Load += new System.EventHandler(this.uc_NhapVanBang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVanBang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgVanBang;
        private System.Windows.Forms.TextBox textXepLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ComboBox cboBoxTrangThai;
        private System.Windows.Forms.TextBox textKhoaHoc;
        private System.Windows.Forms.TextBox textNganhHoc;
        private System.Windows.Forms.TextBox textHoVaTen;
        private System.Windows.Forms.TextBox textMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
