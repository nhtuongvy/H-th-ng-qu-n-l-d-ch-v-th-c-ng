namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    partial class XacNhan
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblXthanhToan = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã OTP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblXthanhToan
            // 
            this.lblXthanhToan.AutoSize = true;
            this.lblXthanhToan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXthanhToan.ForeColor = System.Drawing.Color.Brown;
            this.lblXthanhToan.Location = new System.Drawing.Point(560, -1);
            this.lblXthanhToan.Name = "lblXthanhToan";
            this.lblXthanhToan.Size = new System.Drawing.Size(38, 36);
            this.lblXthanhToan.TabIndex = 19;
            this.lblXthanhToan.Text = "X";
            this.lblXthanhToan.Click += new System.EventHandler(this.lblXthanhToan_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Brown;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(432, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 47);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // XacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 231);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblXthanhToan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "XacNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XacNhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblXthanhToan;
        private System.Windows.Forms.Button btnOK;
    }
}