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
    public partial class Homesp01 : Form
    {
        public Homesp01()
        {
            InitializeComponent();
        }

        private void mnuStripTrangChu_Click(object sender, EventArgs e)
        {
            Home dn = new Home();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void mnuStripDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đăng nhập !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
