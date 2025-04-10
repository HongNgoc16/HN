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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dgVanBang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVanBang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThemMoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 52);
            this.panel1.TabIndex = 0;
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.Location = new System.Drawing.Point(689, 15);
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.Size = new System.Drawing.Size(93, 34);
            this.buttonThemMoi.TabIndex = 3;
            this.buttonThemMoi.Text = "Thêm mới";
            this.buttonThemMoi.UseVisualStyleBackColor = true;
            this.buttonThemMoi.Click += new System.EventHandler(this.buttonThemMoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(950, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(869, 15);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 34);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // dgVanBang
            // 
            this.dgVanBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVanBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVanBang.Location = new System.Drawing.Point(0, 52);
            this.dgVanBang.Name = "dgVanBang";
            this.dgVanBang.RowHeadersWidth = 62;
            this.dgVanBang.RowTemplate.Height = 28;
            this.dgVanBang.Size = new System.Drawing.Size(1040, 493);
            this.dgVanBang.TabIndex = 1;
            // 
            // uc_NhapVanBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgVanBang);
            this.Controls.Add(this.panel1);
            this.Name = "uc_NhapVanBang";
            this.Size = new System.Drawing.Size(1040, 545);
            this.Load += new System.EventHandler(this.uc_NhapVanBang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVanBang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThemMoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgVanBang;
    }
}
