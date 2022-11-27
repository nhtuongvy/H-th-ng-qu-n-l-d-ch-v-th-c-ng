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
    public partial class XemDH : Form
    {
        public XemDH()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void XemDH_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = dtVDH.CurrentRow.Index;
            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            connection.Open();
            string str = "update DHDD  set TrangThai = '" + "Xac nhan" + "' where STT = '" + dtVDH.Rows[i].Cells[0].Value.ToString() + "'";
            command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i;
            i = dtVDH.CurrentRow.Index;
            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            connection.Open();
            string sql = "delete from DHDD Where  STT='" + dtVDH.Rows[i].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
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
