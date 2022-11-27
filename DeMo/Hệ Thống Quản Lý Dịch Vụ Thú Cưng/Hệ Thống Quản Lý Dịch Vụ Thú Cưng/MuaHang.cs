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
    public partial class MuaHang : Form
    {
        public MuaHang()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtname.Text==""|| this.txtdiachi.Text == "" || this.txtphone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

               
              
                SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
                connection.Open();
                float S = 0;
                int c = dataGridView1.Rows.Count;
                for (int i = 0; i < c - 1; i++)
                {
                    S += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                }
                
                string Dl = "";
                int k = dataGridView1.Rows.Count;

                for (int i = 0; i < k - 1; i++)
                {
                    Dl += "MSP:"+dataGridView1.Rows[i].Cells[1].Value.ToString() + " "+"Tên SP: "+dataGridView1.Rows[i].Cells[2].Value.ToString() + ""+"Số Lượng: "+dataGridView1.Rows[i].Cells[3].Value.ToString() +" "+"Đơn giá: "+ dataGridView1.Rows[i].Cells[4].Value.ToString() +  "  ;  ";
                }
                String str = "INSERT INTO DOHANG_DH (TenKH, sdtDH, DiachiDH,ThongTinSP,TongTienSP,ThanhToan) VALUES (@TenKH, @sdtDH, @DiachiDH,@ThongTinSP,@TongTienSP,@ThanhToan)";
                command = new SqlCommand(str, connection);
                command.Parameters.AddWithValue("@TenKH", this.txtname.Text);
                command.Parameters.AddWithValue("@sdtDH", this.txtphone.Text);
                command.Parameters.AddWithValue("@DiachiDH", this.txtdiachi.Text);
                command.Parameters.AddWithValue("@ThongTinSP", Dl);
                command.Parameters.AddWithValue("@TongTienSP", S);
                command.Parameters.AddWithValue("@ThanhToan", "Null");
                command.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                
                for (int i = 0; i < c - 1; i++)
                {
                    string sql = "delete from GIOHANG Where  STT='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();

                }
                connection.Close();
                this.Close();
                ThanhToan bn = new ThanhToan();
                this.Hide();
                bn.ShowDialog();
                this.Show();
            }

           
        }

        private void MuaHang_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            Tong();

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
            dataGridView1.DataSource = dt;

        }

        private void Tong()
        {
            connection.Open();
            float S = 0;
            int c= dataGridView1.Rows.Count;
            for (int i=0; i<c-1; i++)
            {
                S += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            this.txtTongTien.Text = S.ToString();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
