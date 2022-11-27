using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    public partial class ThanhToanOnline : Form
    {
        public ThanhToanOnline()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int t = 0;
            if (this.rd1.Checked)
            {
                
                t =t+ 1;
            }
            if (this.rd3.Checked)
            {
               
                t =t+ 1;
            }
            if (this.rd2.Checked)
            {
               
                t =t+ 1;
            }
            if (this.txtCMND.Text == "" || t == 0 || this.txtMaSoThe.Text == "" || this.txtTenChuThe.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

            this.Close();
            XacNhan bn = new XacNhan();
            this.Hide();
            bn.ShowDialog();
            this.Show();

        }

        private void lblXthanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            ThanhToan bn = new ThanhToan();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void ThanhToanOnline_Load(object sender, EventArgs e)
        {

        }
    }
}
