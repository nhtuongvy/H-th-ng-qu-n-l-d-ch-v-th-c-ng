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
    public partial class sp01 : Form
    {
        public sp01()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mnuStripTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeKhachHangTV tv = new HomeKhachHangTV();
            this.Hide();
            tv.ShowDialog();
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
            MessageBox.Show("Thêm vào giỏ hàng thành công!");

            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            connection.Open();
            /*SqlCommand cmd = new SqlCommand("NhanVien_GetTaiKhoanByPasswordUsername", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", ConstClass.username);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read())
            {
                int stt= dta.GetInt32(3);
                if (stt == 3)
                {*/
                    String str = "insert into GIOHANG(MSP,TENSP,SOLUONG,DONGIA,TONGTIEN) Values (@MSP,@TENSP,@SOLUONG,@DONGIA,@TONGTIEN)";
                    command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@MSP", this.lblMSP.Text);
                    command.Parameters.AddWithValue("@TenSP", this.lblTenSanPham.Text);
                    decimal soLuong = nUDSoLuong.Value;
                    int t = Int32.Parse(this.lblDonGia.Text);
                    command.Parameters.AddWithValue("@SOLUONG", soLuong);
                    command.Parameters.AddWithValue("@DONGIA", this.lblDonGia.Text);
                    int c = (int)soLuong;
                    int S = t * c;
                    command.Parameters.AddWithValue("@TONGTIEN", S);
                    command.ExecuteNonQuery();
                    connection.Close();
                /*}*/
           /* }*/
            

            

        }

        private void giỏHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
