namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    partial class uc_DuyetVanBang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDuyet = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDuyet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgDuyet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 537);
            this.panel2.TabIndex = 1;
            // 
            // dgDuyet
            // 
            this.dgDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDuyet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDuyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDuyet.Location = new System.Drawing.Point(0, 0);
            this.dgDuyet.Name = "dgDuyet";
            this.dgDuyet.RowHeadersWidth = 62;
            this.dgDuyet.RowTemplate.Height = 28;
            this.dgDuyet.Size = new System.Drawing.Size(916, 537);
            this.dgDuyet.TabIndex = 1;
            // 
            // panel3
            // 
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
            this.panel3.Size = new System.Drawing.Size(368, 537);
            this.panel3.TabIndex = 51;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(128, 247);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(88, 36);
            this.buttonTimKiem.TabIndex = 8;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // cboBoxTrangThai
            // 
            this.cboBoxTrangThai.FormattingEnabled = true;
            this.cboBoxTrangThai.Location = new System.Drawing.Point(144, 175);
            this.cboBoxTrangThai.Name = "cboBoxTrangThai";
            this.cboBoxTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cboBoxTrangThai.TabIndex = 0;
            // 
            // textKhoaHoc
            // 
            this.textKhoaHoc.Location = new System.Drawing.Point(144, 131);
            this.textKhoaHoc.Name = "textKhoaHoc";
            this.textKhoaHoc.Size = new System.Drawing.Size(160, 26);
            this.textKhoaHoc.TabIndex = 7;
            // 
            // textNganhHoc
            // 
            this.textNganhHoc.Location = new System.Drawing.Point(144, 92);
            this.textNganhHoc.Name = "textNganhHoc";
            this.textNganhHoc.Size = new System.Drawing.Size(160, 26);
            this.textNganhHoc.TabIndex = 6;
            // 
            // textHoVaTen
            // 
            this.textHoVaTen.Location = new System.Drawing.Point(144, 57);
            this.textHoVaTen.Name = "textHoVaTen";
            this.textHoVaTen.Size = new System.Drawing.Size(160, 26);
            this.textHoVaTen.TabIndex = 5;
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(144, 24);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(160, 26);
            this.textMaSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trạng thái";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Khóa học";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ngành học";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Họ và tên";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã sinh viên";
            // 
            // uc_DuyetVanBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "uc_DuyetVanBang";
            this.Size = new System.Drawing.Size(916, 589);
            this.Load += new System.EventHandler(this.uc_DuyetVanBang_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDuyet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgDuyet;
        private System.Windows.Forms.Panel panel3;
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
