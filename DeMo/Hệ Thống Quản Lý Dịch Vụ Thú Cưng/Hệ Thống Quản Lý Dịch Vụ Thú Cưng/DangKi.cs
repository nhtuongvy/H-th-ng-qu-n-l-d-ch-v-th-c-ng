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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        /*SqlCommand cmd;*/
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlCommand com;

        private void btnDangKi_Click(object sender, EventArgs e)
        {


            if (this.txtHoTen.Text == "" || this.txtSDT.Text == "" || this.txtusername.Text == "" || this.txtpass.Text == "" || this.txtXacNhanMK.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Yêu Cầu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
                connection.Open();
                string ten = txtusername.Text;
                string pass = txtpass.Text;
                string mk = txtXacNhanMK.Text;
                SqlCommand cmd = new SqlCommand("NhanVien_GetTaiKhoanUsername", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", ten);

               using (SqlDataReader dta = cmd.ExecuteReader())
                {
                    if (dta.Read())
                    {

                        dta.Close();
                        MessageBox.Show("Tên đăng nhập đã có người sử dụng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtusername.Text = "";

                    }
                
                   else
                    {
                        dta.Close();
                        if (mk.Equals(pass))
                        {

                            /*SqlCommand com;/* new SqlCommand("NhanVien_GetTaiKhoanByPasswordUsername",connection);
                            com.CommandType = CommandType.StoredProcedure;*/

                          
                            string str = "INSERT INTO TaiKhoan (username, pass, lvl) VALUES (@username, @pass, @lvl)";
                            cmd = new SqlCommand(str, connection);

                            cmd.Parameters.AddWithValue("@username", ten);
                            cmd.Parameters.AddWithValue("@pass", pass);
                            cmd.Parameters.AddWithValue("@lvl", 1);

                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Đăng Kí Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            DangNhap bn = new DangNhap();
                            this.Hide();
                            bn.ShowDialog();
                            this.Show();
                        }
                        else
                        {

                            MessageBox.Show("Mật khẩu xác nhận không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtXacNhanMK.Text = "";
                        }

                    }
                    
                }
               
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtEmail.Text = "";
            this.txtHoTen.Text = "";
            this.txtpass.Text = "";
            this.txtSDT.Text = "";
            this.txtusername.Text = "";
            this.txtXacNhanMK.Text = "";

        }

        private void lblX_Click(object sender, EventArgs e)
        {

            DialogResult dr =MessageBox.Show("Bạn muốn thoát khỏi trang ??", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                DangNhap bn = new DangNhap();
                this.Hide();
                bn.ShowDialog();
                this.Show();
            }
        }
    }
}
