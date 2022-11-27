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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
     
        SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
        private void ketnoicsdl()
        {
            connection.Open();
            string sql = "select * from NhanVien";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;

        }
        private void btThemNV_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            connection.Open();
            string gender = "";
            if (this.radionam.Checked)
            {
                gender = "Nam";
            }

            if (this.radionu.Checked)
            {
                gender = "Nữ";
            }
            String str = "INSERT INTO NhanVien VALUES (@MNV, @hoTen, @gioiTinh, @diaChi, @ngaysinh, @cmnd, @ngayVaoLam, 	@sdt, @chucVu, @email)";
            command = new SqlCommand(str, connection);
            command.Parameters.AddWithValue("@MNV", this.txtMNV.Text);
            command.Parameters.AddWithValue("@hoTen", this.txtHovaTen.Text);
            command.Parameters.AddWithValue("@gioiTinh", gender);
            command.Parameters.AddWithValue("@diaChi", this.txtDiachi.Text);
            command.Parameters.AddWithValue("@ngaysinh", this.dateNgaySinh.Text);
            command.Parameters.AddWithValue("@cmnd", this.txtCMND.Text);
            command.Parameters.AddWithValue("@ngayVaoLam", this.dateNgayvaolam.Text);
            command.Parameters.AddWithValue("@sdt", this.txtSDT.Text);
            command.Parameters.AddWithValue("@chucVu", this.txtChucvu.Text);
            command.Parameters.AddWithValue("@email", this.txtEmail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Thêm nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoicsdl();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            connection.Open();
            int i;
            i = dataGridView1.CurrentRow.Index;
            string sql = "delete from NhanVien Where  MNV='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Xoá nhân viên thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoicsdl();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            string gender = "";
            if (this.radionam.Checked)
            {
                gender = "Nam";
            }

            if (this.radionu.Checked)
            {
                gender = "Nữ";
            }
            MessageBox.Show("Update nhân viên thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string sql = "update NhanVien set hoTen='" + this.txtHovaTen.Text + "', gioiTinh='" + gender + "', diaChi='" + this.txtDiachi.Text + "' , ngaysinh='" + this.dateNgaySinh.Text + "', cmnd='" + this.txtCMND.Text + "' , ngayVaoLam='" + this.dateNgayvaolam.Text + "', sdt='" + this.txtSDT.Text + "', chucVu='" + this.txtChucvu.Text + "' , email='" + this.txtEmail.Text + "' Where MNV='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            ketnoicsdl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            this.txtMNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.txtHovaTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
          
            if (dataGridView1.Rows[i].Cells[2].Value.ToString().Equals("Nam"))
            {
                this.radionam.Checked = true;
            }
            if (dataGridView1.Rows[i].Cells[3].Value.ToString().Equals("Nữ"))
            {
                this.radionu.Checked = true;
            }

            this.txtDiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.dateNgaySinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.txtCMND.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            this.dateNgayvaolam.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            this.txtSDT.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            this.txtChucvu.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            this.txtEmail.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Home bn = new Home();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }
    }
}
