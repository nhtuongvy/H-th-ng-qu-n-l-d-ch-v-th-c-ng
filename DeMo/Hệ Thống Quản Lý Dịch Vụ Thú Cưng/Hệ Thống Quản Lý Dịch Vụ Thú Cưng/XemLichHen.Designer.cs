namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    partial class XemLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemLichHen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStripTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripDatLich = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtXemLichHen = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXemLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStripTrangChu,
            this.mnuStripTaiKhoan,
            this.mnuStripDatLich});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 4;
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
            this.mnuStripDatLich.Size = new System.Drawing.Size(125, 29);
            this.mnuStripDatLich.Text = "Xem lịch hẹn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dtXemLichHen
            // 
            this.dtXemLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtXemLichHen.Location = new System.Drawing.Point(0, 233);
            this.dtXemLichHen.Name = "dtXemLichHen";
            this.dtXemLichHen.RowTemplate.Height = 28;
            this.dtXemLichHen.Size = new System.Drawing.Size(1001, 365);
            this.dtXemLichHen.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(694, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Brown;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Transparent;
            this.btnHuy.Location = new System.Drawing.Point(857, 633);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 66);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // XemLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 725);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtXemLichHen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "XemLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemLichHen";
            this.Load += new System.EventHandler(this.XemLichHen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXemLichHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStripTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuStripTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuStripDatLich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtXemLichHen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHuy;
    }
}