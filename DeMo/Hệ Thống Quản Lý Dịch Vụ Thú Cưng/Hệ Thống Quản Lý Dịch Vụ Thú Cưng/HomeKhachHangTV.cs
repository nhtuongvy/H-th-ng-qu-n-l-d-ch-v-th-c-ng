using Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng.ConstValue;
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
    public partial class HomeKhachHangTV : Form
    {
        public HomeKhachHangTV()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void sp01_Click(object sender, EventArgs e)
        {
            this.Close();
            sp01 bn = new sp01();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void giỏHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void mnuStripDatLich_Click(object sender, EventArgs e)
        {
            this.Close();
            DatLich bn = new DatLich();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void HomeKhachHangTV_Load(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DonHang bn = new DonHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
