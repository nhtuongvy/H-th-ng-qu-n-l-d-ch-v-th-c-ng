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
    public partial class DatLich : Form
    {
        public DatLich()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            int t = 0;
            string h = "";
            string m = "";
            if (this.radioButton1.Checked)
            {
                t = t + 1;
                h = "7h-9h";
            }
            if (this.radioButton2.Checked)
            {
                t = t + 1;
                h = "9h-11h";
            }
            if (this.radioButton3.Checked)
            {
                t = t + 1;
                h = "13h-15h";
            }
            if (this.radioButton4.Checked)
            {
                t = t + 1;
                h = "15h-17h";
            }

            int n = 0;
            if (this.chkChamthucung.Checked)
            {
                n = n + 1;
                m = "Chăm sóc cho thú cưng";
            }
            if (this.chkKham.Checked)
            {
                n = n + 1;
                m = "Khám bệnh cho thú cưng";

            }
            if (this.chklamdep.Checked)
            {
                n = n + 1;
                m = "Làm đẹp cho thú cưng";
            }

            if (this.txtHoTen.Text==""||this.txtMoTa.Text==""||this.txtSDT.Text==""|| t==0 || n==0)
            {
                MessageBox.Show("Vui Lòng chọn và nhập đầy đủ thông tin!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                DateTime ngayDatLich = Convert.ToDateTime(dateDatLich.SelectionEnd.ToShortDateString());

                
                    MessageBox.Show("Đặt lịch thành công!");
            
                    SqlConnection connection = new SqlConnection(ConstClass.ConnectString);
                    connection.Open();
                    String str = "INSERT INTO DATLICH (hoten,sdt,ngay,khunggio,dichvu,mota) VALUES (@hoten, @sdt, @ngay, @khunggio, @dichvu, @mota)";
                    command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@hoten", this.txtHoTen.Text);
                    command.Parameters.AddWithValue("@sdt", this.txtSDT.Text);
                    command.Parameters.AddWithValue("@ngay",ngayDatLich);
                    command.Parameters.AddWithValue("@khunggio", h);
                    command.Parameters.AddWithValue("@dichvu", m);
                    command.Parameters.AddWithValue("@mota", this.txtMoTa.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                
            }
        }

        private void chkKhungGio_SelectedIndexChanged(object sender, EventArgs e)
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

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GioHang bn = new GioHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            DonHang bn = new DonHang();
            this.Hide();
            bn.ShowDialog();
            this.Show();
        }

        private void dateDatLich_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime ngayDatLich = Convert.ToDateTime(dateDatLich.SelectionEnd.ToShortDateString());
            DateTime today = Convert.ToDateTime(dateDatLich.TodayDate.ToShortDateString());
            TimeSpan interval = ngayDatLich.Subtract(today);

            if (interval.TotalHours < 48)
            {
                MessageBox.Show("Phải đặt lịch trước 24h!");
            }
        }
    }
}
