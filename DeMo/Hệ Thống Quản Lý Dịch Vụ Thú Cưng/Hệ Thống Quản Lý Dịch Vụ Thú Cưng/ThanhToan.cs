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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void lblx_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void btnThanhToanOnline_Click(object sender, EventArgs e)
        {
            
            this.Close();
            ThanhToanOnline bn = new ThanhToanOnline();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void btnThanhToanTrucTiep_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            connection.Open();
            string str = "update  DOHANG_DH set ThanhToan = '"+ "Chưa Thanh Toán" + "' where ThanhToan = '" + "Null" + "'";
            command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
            DatHang bn = new DatHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
