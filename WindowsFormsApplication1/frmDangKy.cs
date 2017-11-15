using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        string connstr=@"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL;Integrated Security = true;";
        string commstr;
        SqlCommand comm;
        SqlConnection conn;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            ActiveControl = txtTenDangNhap;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length <= txtXacNhanMatKhau.Text.Length + 2)
            {
                if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                {
                    lbmatkhaukhongKhop.Visible = true;
                }
                else
                    lbmatkhaukhongKhop.Visible = false;
            }
            else
                lbmatkhaukhongKhop.Visible = false;

        }

        private void txtXacNhanMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab)
            {
                if(txtXacNhanMatKhau.Text!=txtMatKhau.Text)
                {
                    lbmatkhaukhongKhop.Visible = true;
                }
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if(lbmatkhaukhongKhop.Visible||lbtaikhoandatontai.Visible)//.... 1 số lb khác nữa
            {
                MessageBox.Show("Thông tin không đạt tiêu chuẩn.\nXin kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(txtDiaChi.Text==""||txtEmail.Text==""||txtHoTen.Text==""||txtMatKhau.Text==""||txtSoDienThoai.Text==""|txtTenDangNhap.Text==""||txtXacNhanMatKhau.Text==""||cbxgioitinh.SelectedIndex==-1||cbxNgaysinh.SelectedIndex==-1||cbxThangSinh.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                #region Sử dụng store procedure
                string birthday = cbxnamsinh.Text + cbxThangSinh.Text + cbxNgaysinh.Text;
                //DateTime birthday1 = Convert.ToDateTime(birthday);
                bool gioitinh = true;
                if (cbxgioitinh.SelectedItem.ToString() == "Nam") gioitinh = true;
                else gioitinh = false;

                //Gọi thủ tục insert UserInfo.
                comm = new SqlCommand();
                comm.CommandText = "InsertNewUserInfo";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.Add("@Name", SqlDbType.NChar, 50);
                comm.Parameters["@Name"].SqlValue = txtHoTen.Text;

                comm.Parameters.AddWithValue("@Birthday", birthday);
                comm.Parameters[1].SqlDbType = SqlDbType.Char;
                comm.Parameters[1].Size = 8;

                comm.Parameters.Add("@Address", SqlDbType.NVarChar);
                comm.Parameters["@Address"].SqlValue = txtDiaChi.Text;
                comm.Parameters["@Address"].Size = 100;

                comm.Parameters.Add("@Sex", SqlDbType.Bit);
                comm.Parameters[3].SqlValue = gioitinh;

                comm.Parameters.Add("@Phone", SqlDbType.NVarChar);
                comm.Parameters[4].SqlValue = txtSoDienThoai.Text;

                comm.Parameters.Add("@Mail", SqlDbType.NVarChar, 30);
                comm.Parameters[5].SqlValue = txtEmail.Text;

                comm.Parameters.Add("@Account", SqlDbType.NVarChar, 40);
                comm.Parameters[6].SqlValue = txtTenDangNhap.Text;

                comm.Parameters.Add("@Passwd", SqlDbType.NVarChar, 40);
                comm.Parameters[7].SqlValue = txtMatKhau.Text;

                conn = new SqlConnection(connstr);
                conn.Open();
                comm.Connection = conn;
                int thanhcong = comm.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                if (thanhcong  > 0)
                {
                    MessageBox.Show("Đăng ký thành công! Chúc bạn học tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDangNhap dn = new frmDangNhap();
                    dn.Show();
                    this.Hide();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công! Hãy kiểm trả lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                #endregion :'(

                #region Không dùng stored proceduren nhưng dùng parameters
                //string birthday = cbxnamsinh.Text + cbxThangSinh.Text + cbxNgaysinh.Text;
                //bool gioitinh;
                //if (cbxgioitinh.Text == "Nam") gioitinh = true;
                //else gioitinh = false;
                //comm = new SqlCommand();

                //comm.CommandText = " Insert Into UserInfo values(@Name,@Birth,@Add,@Sex,@Phone,@Mail,@Acc,@Pass)";

                //comm.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                //comm.Parameters[0].SqlValue = txtHoTen.Text;

                //comm.Parameters.Add("@Birth", SqlDbType.NVarChar, 50);
                //comm.Parameters[1].SqlValue = birthday;

                //comm.Parameters.Add("@Add", SqlDbType.NVarChar, 100);
                //comm.Parameters[2].SqlValue = txtDiaChi.Text;

                //comm.Parameters.Add("@Sex", SqlDbType.Bit);
                //comm.Parameters[3].SqlValue = gioitinh;

                //comm.Parameters.Add("@Phone", SqlDbType.NVarChar, 50);
                //comm.Parameters[4].SqlValue = txtSoDienThoai.Text;

                //comm.Parameters.Add("@Mail", SqlDbType.NVarChar, 50);
                //comm.Parameters[5].SqlValue = txtEmail.Text;

                //comm.Parameters.Add("@Acc", SqlDbType.NVarChar, 50);
                //comm.Parameters[6].SqlValue = txtTenDangNhap.Text;

                //comm.Parameters.Add("@Pass", SqlDbType.NVarChar, 50);
                //comm.Parameters[7].SqlValue = txtMatKhau.Text;
                //conn = new SqlConnection(connstr);
                //conn.Open();
                //comm.Connection = conn;
                //int thanhcong = comm.ExecuteNonQuery();  //Tại sao lại trả về số lớn hơn 2 nhỉ?? Liệu có phải là ở cả bảng inserted nữa?
                //conn.Close();                            //Không phải: Mình có trigger tự động tạo ở  UserLevel nên mới là 2 hihihi
                //conn.Dispose();
                //if (thanhcong > 0)
                //{
                //    MessageBox.Show("Đăng ký thành công!Chúc bạn học tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmDangNhap dn = new frmDangNhap();
                //    dn.Show();
                //    this.Close();
                //    this.Dispose();

                //}
                //else
                //    MessageBox.Show("Đăng không ký thành công!Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion, nhưng dùng parameters

                #region dùng câu lệnh insert bình thường
                //string birthday = cbxnamsinh.Text + cbxThangSinh.Text + cbxNgaysinh.Text;
                //bool gioitinh;
                //if (cbxgioitinh.Text == "Nam") gioitinh = true;
                //else gioitinh = false;
                //commstr = "Insert UserInfo values('" + txtHoTen.Text + "','" + birthday + "','"
                //            + txtDiaChi.Text + "','" + gioitinh.ToString() + "','" + txtSoDienThoai.Text + "','"
                //            + txtEmail.Text + "','" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "');";
                //conn = new SqlConnection(connstr);
                //conn.Open();
                //comm = new SqlCommand(commstr, conn);
                //int thanhcong = comm.ExecuteNonQuery();
                //conn.Close();
                //conn.Dispose();
                //if (thanhcong == 1)
                //{
                //    MessageBox.Show("Đăng ký thành công!Chúc bạn học tốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmDangNhap dn = new frmDangNhap();
                //    dn.Show();
                //    this.Close();
                //    this.Dispose();

                //}
                //else
                //    MessageBox.Show("Đăng không ký thành công! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                #endregion
            }

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            commstr = "select * from UserInfo where UIAccount = '" + txtTenDangNhap.Text + "';";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            int x = comm.ExecuteNonQuery();
            if (x > 0)
            {
                lbtaikhoandatontai.Visible = true;
            }
            else
                lbtaikhoandatontai.Visible = false;

            conn.Close();
            conn.Dispose();
        }
    }
}
