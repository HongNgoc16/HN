namespace QuanLyVanBangTotNghiep_BTL.GUI
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkHienThiMK = new System.Windows.Forms.CheckBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.textTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkHienThiMK);
            this.panel1.Controls.Add(this.textMatKhau);
            this.panel1.Controls.Add(this.textTenDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 414);
            this.panel1.TabIndex = 2;
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonQuayLai.CausesValidation = false;
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonQuayLai.Location = new System.Drawing.Point(202, 346);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(175, 53);
            this.buttonQuayLai.TabIndex = 9;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(145, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // checkHienThiMK
            // 
            this.checkHienThiMK.AutoSize = true;
            this.checkHienThiMK.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHienThiMK.Location = new System.Drawing.Point(10, 305);
            this.checkHienThiMK.Name = "checkHienThiMK";
            this.checkHienThiMK.Size = new System.Drawing.Size(161, 25);
            this.checkHienThiMK.TabIndex = 7;
            this.checkHienThiMK.Text = "Hiển thị mật khẩu";
            this.checkHienThiMK.UseVisualStyleBackColor = true;
            this.checkHienThiMK.CheckedChanged += new System.EventHandler(this.checkHienThiMK_CheckedChanged);
            // 
            // textMatKhau
            // 
            this.textMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatKhau.Location = new System.Drawing.Point(9, 254);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(368, 35);
            this.textMatKhau.TabIndex = 6;
            this.textMatKhau.UseSystemPasswordChar = true;
            // 
            // textTenDangNhap
            // 
            this.textTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenDangNhap.Location = new System.Drawing.Point(9, 168);
            this.textTenDangNhap.Name = "textTenDangNhap";
            this.textTenDangNhap.Size = new System.Drawing.Size(368, 39);
            this.textTenDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(3, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDangNhap.CausesValidation = false;
            this.buttonDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDangNhap.Location = new System.Drawing.Point(9, 346);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(177, 53);
            this.buttonDangNhap.TabIndex = 2;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(4, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 446);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkHienThiMK;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.TextBox textTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label label1;
    }
}