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
    public partial class HomeNVCSKH : Form
    {
        public HomeNVCSKH()
        {
            InitializeComponent();
        }

        private void mnuStripDatLich_Click(object sender, EventArgs e)
        {
            this.Close();
            XemLichHen bn = new XemLichHen();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void mnuStripTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeNVCSKH bn = new HomeNVCSKH();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void mnuStripDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoiMatKhau bn = new frmDoiMatKhau();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void mnuStripDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Home bn = new Home();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
