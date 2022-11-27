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
    public partial class frmDoiMatKhau : Form
    {
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.txtTenDangNhap.Text = ConstClass.username;
            this.txtTenDangNhap.Enabled = false;
            
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            connection.Open();
            string matKhauCu = this.txtMatKhauCu.Text;
            string matKhauMoi = this.txtMatKhauMoi.Text;
            string xacNhanMatKhau = this.txtXacNhanMatKhau.Text;

            SqlCommand cmd = new SqlCommand("NhanVien_GetTaiKhoanByPasswordUsername", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", ConstClass.username);
            cmd.Parameters.AddWithValue("@password", matKhauCu);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read())
            {
                dta.Close();
                if (matKhauMoi.Equals(xacNhanMatKhau))
                {
                    string sql = "update TaiKhoan set pass = '" + matKhauMoi + "' where username = '" + ConstClass.username + "'";
                    
                    cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtXacNhanMatKhau.Text = "";
                    frmDoiMatKhau dn = new frmDoiMatKhau();
                    this.Hide();
                    dn.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                dta.Close();
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmDoiMatKhau dn = new frmDoiMatKhau();
                this.Hide();
                dn.ShowDialog();
                this.Show();
            }

          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn huỷ  đổi mật khẩu ???",
                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtMatKhauCu.Text = "";
                txtMatKhauMoi.Text = "";
                txtXacNhanMatKhau.Text = "";
            }

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = MessageBox.Show("Bạn thật sự muốn thoát trang ???",
               "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                HomeKhachHangTV bn = new HomeKhachHangTV();
                this.Hide();
                bn.ShowDialog();
                this.Show();
            }
        }
    }
}
