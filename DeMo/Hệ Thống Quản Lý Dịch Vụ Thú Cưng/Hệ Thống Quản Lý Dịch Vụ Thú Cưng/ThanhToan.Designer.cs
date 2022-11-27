namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThanhToanOnline = new System.Windows.Forms.Button();
            this.btnThanhToanTrucTiep = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng chọn hình thức thanh toán";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnThanhToanOnline
            // 
            this.btnThanhToanOnline.BackColor = System.Drawing.Color.Brown;
            this.btnThanhToanOnline.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanOnline.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanOnline.Location = new System.Drawing.Point(37, 162);
            this.btnThanhToanOnline.Name = "btnThanhToanOnline";
            this.btnThanhToanOnline.Size = new System.Drawing.Size(202, 53);
            this.btnThanhToanOnline.TabIndex = 2;
            this.btnThanhToanOnline.Text = "Thanh toán online";
            this.btnThanhToanOnline.UseVisualStyleBackColor = false;
            this.btnThanhToanOnline.Click += new System.EventHandler(this.btnThanhToanOnline_Click);
            // 
            // btnThanhToanTrucTiep
            // 
            this.btnThanhToanTrucTiep.BackColor = System.Drawing.Color.Brown;
            this.btnThanhToanTrucTiep.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanTrucTiep.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanTrucTiep.Location = new System.Drawing.Point(311, 162);
            this.btnThanhToanTrucTiep.Name = "btnThanhToanTrucTiep";
            this.btnThanhToanTrucTiep.Size = new System.Drawing.Size(202, 53);
            this.btnThanhToanTrucTiep.TabIndex = 3;
            this.btnThanhToanTrucTiep.Text = "Thanh toán trực tiếp";
            this.btnThanhToanTrucTiep.UseVisualStyleBackColor = false;
            this.btnThanhToanTrucTiep.Click += new System.EventHandler(this.btnThanhToanTrucTiep_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.Brown;
            this.lblx.Location = new System.Drawing.Point(489, 9);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(38, 36);
            this.lblx.TabIndex = 5;
            this.lblx.Text = "X";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 441);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnThanhToanTrucTiep);
            this.Controls.Add(this.btnThanhToanOnline);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThanhToanOnline;
        private System.Windows.Forms.Button btnThanhToanTrucTiep;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblx;
    }
}