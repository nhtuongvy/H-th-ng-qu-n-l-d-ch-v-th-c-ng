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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn thoát khỏi chương trình?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
            try
            {
                connection.Open();
                string taiKhoan = this.txtUsername.Text;
                string matKhau = this.txtPassword.Text;
                SqlCommand cmd = new SqlCommand("NhanVien_GetTaiKhoanByPasswordUsername", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", taiKhoan);
                cmd.Parameters.AddWithValue("@password", matKhau);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read())
                {
                    int level = dta.GetInt32(2);
                    ConstClass.username = taiKhoan;
                    if (level == 0)
                    {
                        this.Close();
                        HomeQuanLy tv = new HomeQuanLy();
                        this.Hide();
                        tv.ShowDialog();
                        this.Show();
                    }
                    if (level == 1)
                    {
                        MessageBox.Show("Chào " + taiKhoan + "  ghé thăm PETSHOP", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        HomeKhachHangTV tv = new HomeKhachHangTV();
                        this.Hide();
                        tv.ShowDialog();
                        this.Show();
                    }
                    if (level == 2)
                    {
                        this.Close();
                        HomeNVCSKH tv = new HomeNVCSKH();
                        this.Hide();
                        tv.ShowDialog();
                        this.Show();
                    }
                    if (level == 3)
                    {
                        this.Close();
                        HomeNVBH tv = new HomeNVBH();
                        this.Hide();
                        tv.ShowDialog();
                        this.Show();
                    }

                    dta.Close();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi đăng nhập!");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Close();
            DangKi tv = new DangKi();
            this.Hide();
            tv.ShowDialog();
            this.Show();
        }
    }
}
