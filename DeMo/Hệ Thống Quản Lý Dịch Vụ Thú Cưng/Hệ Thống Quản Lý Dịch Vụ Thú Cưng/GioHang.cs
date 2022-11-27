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
    public partial class GioHang : Form
    {
     
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public GioHang()
        {
            InitializeComponent();
        }

        private void dtGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
           /* Tong();*/
        }
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
       
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from GIOHANG";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dtGioHang.DataSource = dt;

        }
       /* private void Tong()
        {
            connection.Open();
            float S = 0;
            int c = dtGioHang.Rows.Count;
            for (int i = 0; i < c - 1; i++)
            {
                S += float.Parse(dtGioHang.Rows[i].Cells[5].Value.ToString());
            }
            this.txtTongTien.Text = S.ToString();
        }*/

        private void đạtLịchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeKhachHangTV bn = new HomeKhachHangTV();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoiMatKhau bn = new frmDoiMatKhau();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Home bn = new Home();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            connection.Open();
            int i;
            i = dtGioHang.CurrentRow.Index;
            string sql = "delete from GIOHANG Where  STT='" + dtGioHang.Rows[i].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
        
            int h = dtGioHang.Rows.Count;
            if ((h-1) == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
                MuaHang bn = new MuaHang();
                this.Hide();
                bn.ShowDialog();
                this.Show();
            }
            
           
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
