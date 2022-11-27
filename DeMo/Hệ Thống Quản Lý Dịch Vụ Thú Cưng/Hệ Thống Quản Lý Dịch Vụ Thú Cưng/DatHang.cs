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
    public partial class DatHang : Form
    {
        public DatHang()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void DatHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
           

            /*load_textBox();*/
        }
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from DOHANG_DH";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;

        }
        
        /*private void Tong()
        {
            connection.Open();
            float S = 0;
            int c = dataGridView1.Rows.Count;
            for (int i = 0; i < c - 1; i++)
            {
                S += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            this.txtTongTien.Text = S.ToString();
        }*/

        private void btnDH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Open();
            int k = dataGridView1.Rows.Count;
            for (int i=0; i < k - 1; i++)
            {
                String str = "INSERT INTO DHDD (TenKH, sdtDH, DiachiDH,ThongTinSP,TongTienSP,ThanhToan) VALUES (@TenKH, @sdtDH, @DiachiDH,@ThongTinSP,@TongTienSP,@ThanhToan)";
                command = new SqlCommand(str, connection);
                command.Parameters.AddWithValue("@TenKH", dataGridView1.Rows[i].Cells[1].Value.ToString());
                command.Parameters.AddWithValue("@sdtDH", dataGridView1.Rows[i].Cells[2].Value.ToString());
                command.Parameters.AddWithValue("@DiachiDH", dataGridView1.Rows[i].Cells[3].Value.ToString());
                command.Parameters.AddWithValue("@ThongTinSP", dataGridView1.Rows[i].Cells[4].Value.ToString());
                command.Parameters.AddWithValue("@TongTienSP", dataGridView1.Rows[i].Cells[5].Value.ToString());
                command.Parameters.AddWithValue("@ThanhToan", dataGridView1.Rows[i].Cells[6].Value.ToString());
                command.ExecuteNonQuery();
            }
            connection.Close();
            connection.Open();
            int h = dataGridView1.Rows.Count;
            for (int j = 0; j < h - 1; j++)
            {
                string sql = "delete from DOHANG_DH Where  STT='" + dataGridView1.Rows[j].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();



        }

        private void mnuStripTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeKhachHangTV bn = new HomeKhachHangTV();
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

        private void mnuStripDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDoiMatKhau bn = new frmDoiMatKhau();
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

        private void giỏHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
