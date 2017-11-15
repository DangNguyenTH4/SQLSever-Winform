using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmDangNhap : Form
    {
        private int uiid;
        //private string account;
        public frmDangNhap()
        { 
            //Đã có sự thay thế là khởi động frmKhoiDong truoc
            //Thread t = new Thread(new ThreadStart(VaoKhoiDong));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Abort();
        }
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL; Integrated Security =true;";
        string commstr;
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dtread;
        string pass;

        private string LopKetNoi()
        {
            string chuoiKetnoi = @"Server=SMC-PC\SQLEXPRESS;Database=ProjectBig_SQL;"
                                    +"Integrated Security=true;"
                                    + "uid=" + txtTenDangNhap.Text + ";"
                                    + "password=" + txtMatkhau.Text;
            return chuoiKetnoi;
        }



        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ActiveControl = txtTenDangNhap;
        }
        private void VaoKhoiDong()
        {
            Application.Run(new frmKhoiDong());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Khi khong nhap acc,pass
            if (txtMatkhau.Text == "" || txtTenDangNhap.Text == "")
            {
                if (txtMatkhau.Text == "" && txtTenDangNhap.Text != "")
                {
                    MessageBox.Show("Please! Fully your password");
                    ActiveControl = txtMatkhau;

                }
                else if (txtMatkhau.Text != "" && txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Please! Fully your account");
                    ActiveControl = txtTenDangNhap;

                }
                else
                {
                    ActiveControl = txtTenDangNhap;
                    MessageBox.Show("Please! Fully your account and password");
                    //Muoons cho cursor chi vao o chua dien nua
                }
            }
            #endregion
            else
            {
                #region kết nối là admin
                if (checkBox2.Checked==true)
                {
                    connstr = LopKetNoi();
                    try
                    {
                        conn = new SqlConnection(connstr);
                        conn.Open();
                        MessageBox.Show("Successfully!");
                        conn.Close();
                        frmForAdmin adm = new frmForAdmin(txtTenDangNhap.Text,txtMatkhau.Text);
                        adm.Show();
                        this.Hide();


                    }
                    catch
                    {
                        MessageBox.Show("Can not connect! Please your check again!"
                                        + "\nMaybe you are not Admin!");
                    }
                }
                #endregion
                #region ket noi là user
                else
                {
                    string connstr = @"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL; Integrated Security =true;";
                    commstr = " select UserInfo.UIID,UserInfo.UIPasswd from UserInfo  where UserInfo.UIAccount = '" + txtTenDangNhap.Text + "';";
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    comm = new SqlCommand(commstr, conn);
                    //int x = comm.ExecuteNonQuery();
                    dtread = comm.ExecuteReader();
                    if (!dtread.HasRows)
                    {
                        lbthongbaoSaiAcc.Visible = true;
                        ActiveControl = txtTenDangNhap;

                    }
                    else
                    {
                        while (dtread.Read())
                        {
                            pass = dtread[1].ToString();
                            uiid = Convert.ToInt32(dtread[0]);
                        }
                        if (!(pass == txtMatkhau.Text))
                        {
                            lbthongbaosaiPass.Visible = true;
                            ActiveControl = txtMatkhau;
                        }
                        else
                        {
                            frmHoc hoc = new frmHoc(uiid, txtTenDangNhap.Text);
                            this.Hide();
                            hoc.Show();
                            //this.Close();
                            //this.Dispose();
                        }
                    }
                    //if(x==0)
                    //{
                    //    lbthongbao.Visible = false;
                    //}
                    //else
                    //{
                    //    if(txtMatkhau.Text!=)
                    //}
                }

            }
            #endregion




        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lbthongbaoSaiAcc.Visible = false;
            lbthongbaosaiPass.Visible = false;
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            lbthongbaoSaiAcc.Visible = false;
            lbthongbaosaiPass.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmDangKy dangky = new frmDangKy();
            this.Hide();
            dangky.Show();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.k)
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Tab)
            {
                //ActiveControl = txtMatkhau;
                txtMatkhau.Focus();
            }
            if (e.KeyCode == Keys.Enter)
                ActiveControl = txtMatkhau;
        }
    }
}
