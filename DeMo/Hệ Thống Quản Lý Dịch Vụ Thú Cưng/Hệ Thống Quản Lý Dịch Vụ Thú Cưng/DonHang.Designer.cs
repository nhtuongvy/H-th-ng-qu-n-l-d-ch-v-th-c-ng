namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    partial class DonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStripTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDatLich = new System.Windows.Forms.ToolStripMenuItem();
            this.giỏHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtVDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVDH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStripTrangChu,
            this.mnuStripTaiKhoan,
            this.mnuStripDatLich,
            this.giỏHàngToolStripMenuItem1,
            this.đơnHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStripTrangChu
            // 
            this.mnuStripTrangChu.Name = "mnuStripTrangChu";
            this.mnuStripTrangChu.Size = new System.Drawing.Size(103, 29);
            this.mnuStripTrangChu.Text = "Trang Chủ";
            this.mnuStripTrangChu.Click += new System.EventHandler(this.mnuStripTrangChu_Click);
            // 
            // mnuStripTaiKhoan
            // 
            this.mnuStripTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStripDoiMatKhau,
            this.mnuStripDangXuat});
            this.mnuStripTaiKhoan.Name = "mnuStripTaiKhoan";
            this.mnuStripTaiKhoan.Size = new System.Drawing.Size(99, 29);
            this.mnuStripTaiKhoan.Text = "Tài Khoản";
            // 
            // mnuStripDoiMatKhau
            // 
            this.mnuStripDoiMatKhau.Name = "mnuStripDoiMatKhau";
            this.mnuStripDoiMatKhau.Size = new System.Drawing.Size(204, 30);
            this.mnuStripDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.mnuStripDoiMatKhau.Click += new System.EventHandler(this.mnuStripDoiMatKhau_Click);
            // 
            // mnuStripDangXuat
            // 
            this.mnuStripDangXuat.Name = "mnuStripDangXuat";
            this.mnuStripDangXuat.Size = new System.Drawing.Size(204, 30);
            this.mnuStripDangXuat.Text = "Đăng Xuất";
            this.mnuStripDangXuat.Click += new System.EventHandler(this.mnuStripDangXuat_Click);
            // 
            // mnuStripDatLich
            // 
            this.mnuStripDatLich.Name = "mnuStripDatLich";
            this.mnuStripDatLich.Size = new System.Drawing.Size(87, 29);
            this.mnuStripDatLich.Text = "Đặt Lịch";
            this.mnuStripDatLich.Click += new System.EventHandler(this.mnuStripDatLich_Click);
            // 
            // giỏHàngToolStripMenuItem1
            // 
            this.giỏHàngToolStripMenuItem1.Name = "giỏHàngToolStripMenuItem1";
            this.giỏHàngToolStripMenuItem1.Size = new System.Drawing.Size(99, 29);
            this.giỏHàngToolStripMenuItem1.Text = "Giỏ Hàng";
            this.giỏHàngToolStripMenuItem1.Click += new System.EventHandler(this.giỏHàngToolStripMenuItem1_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // dtVDH
            // 
            this.dtVDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVDH.Location = new System.Drawing.Point(12, 261);
            this.dtVDH.Name = "dtVDH";
            this.dtVDH.RowTemplate.Height = 28;
            this.dtVDH.Size = new System.Drawing.Size(978, 248);
            this.dtVDH.TabIndex = 4;
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.dtVDH);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonHang";
            this.Load += new System.EventHandler(this.DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStripTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuStripTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDatLich;
        private System.Windows.Forms.ToolStripMenuItem giỏHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtVDH;
    }
}