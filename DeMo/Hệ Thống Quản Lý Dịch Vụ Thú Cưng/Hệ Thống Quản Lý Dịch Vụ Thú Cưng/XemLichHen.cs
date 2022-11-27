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
    public partial class XemLichHen : Form
    {
        public XemLichHen()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void XemLichHen_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from DATLICH";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dtXemLichHen.DataSource = dt;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            connection.Open();
            int i;
            i = dtXemLichHen.CurrentRow.Index;
            string sql = "delete from DATLICH Where  STT='" + dtXemLichHen.Rows[i].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = dtXemLichHen.CurrentRow.Index;
            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            connection.Open();
            string str = "update  DATLICH set TrangThai = '" + "Xac nhan" + "' where STT = '" + dtXemLichHen.Rows[i].Cells[0].Value.ToString() + "'";
            command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
        }
    }
}
