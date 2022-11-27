using Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng.ConstValue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_Thống_Quản_Lý_Dịch_Vụ_Thú_Cưng
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void DonHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
          
        }
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from DHDD";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dtVDH.DataSource = dt;

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

        private void mnuStripTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeKhachHangTV bn = new HomeKhachHangTV();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
