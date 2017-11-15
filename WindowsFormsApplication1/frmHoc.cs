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
using System.IO;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class frmHoc : Form
    {
        private int uiid; //Luôn luôn có để xác định mã người dùng
        private string account;
        public frmHoc()
        {
            InitializeComponent();
        }
        public frmHoc(int uiid1,string account1):this()
        {
            uiid = uiid1;
            account = account1;
        }
        #region Khởi tạo đối tượng két nỗi và chuỗi kết nối
        string connstr = @"Data Source=SMC-PC\SQLEXPRESS;Initial Catalog=ProjectBig_Sql;Integrated Security=True";
        string commstr;
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader sqldtreader;
        SqlDataAdapter dad;
        //SqlDataAdapter dadUserLearn;
        DataTable dtb, dtbUserLearn;//,dtbChange;
        DataSet dts;
       // DataRow dtr;
        #endregion
        string folder = @"C:\Myproject";
        int total = 1;
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Click để tra từ điển
        private void button1_Click(object sender, EventArgs e)
        {
            frmDictionary dic = new frmDictionary();
            //dic.MdiParent = this;
            this.Hide();
            dic.Show();
        }

        private void UpdateUserLearn(DataSet dts)
        {
            string commstringSelect = "Select * from UserLearning where uiid = @UIID";
            string commstringInsert = "Insert into UserLearning values(@UIID,@IDQA)";
            string commstringUpdate = "Update UserLearning set ULearnRemembered = 1 where IDQA =@IDQA";
            string commstringDelelte = "delete from UserLearning where IDQA =@IDQA";

            SqlCommand commSelect;
            SqlCommand commUpdate;
            SqlCommand commDelete;
            SqlCommand commInsert;

            SqlDataAdapter dadUpdate;

            DataSet dtsChange;

            SqlParameter prmDelete, prmUpdate;

            conn = new SqlConnection(connstr);
            conn.Open();

            commSelect = new SqlCommand(commstringSelect,conn);
            commInsert = new SqlCommand(commstringInsert,conn);
            commUpdate = new SqlCommand(commstringUpdate,conn);
            commDelete = new SqlCommand(commstringDelelte,conn);

            dadUpdate = new SqlDataAdapter(commstringSelect, conn);
            dadUpdate.SelectCommand = commSelect;
            dadUpdate.InsertCommand = commInsert;
            dadUpdate.DeleteCommand = commDelete;
            dadUpdate.UpdateCommand = commUpdate;

            prmDelete = dadUpdate.DeleteCommand.Parameters.Add("@IDQA", SqlDbType.Int, 5, "IDQA");
            prmDelete.Direction = ParameterDirection.Input;
            prmDelete.SourceVersion = DataRowVersion.Original;

            //            commUpdate.Parameters.Add("@IDQA", SqlDbType.Int, 5, "IDQA");

            prmUpdate = dadUpdate.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 5, "ID");
            prmUpdate.Direction = ParameterDirection.Input;
            prmUpdate.SourceVersion = DataRowVersion.Original;


            commInsert.Parameters.Add("@UIID", SqlDbType.Int, 5, "UIID");
            commInsert.Parameters.Add("@IDQA", SqlDbType.Int, 5, "IDQA");

            if(dts.HasChanges())
            {
                dtsChange = dts.GetChanges();
                if (dtsChange.HasErrors)
                {
                    dts.RejectChanges();
                }
                else
                    dadUpdate.Update(dtsChange, "UserLearning");
            }
            conn.Close();

        }
        
        private void InserInToUserLearning(int uiid,int idqa)
        {
            commstr = "insert into UserLearning values(" + uiid + "," + idqa + ",0 );";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            int x = comm.ExecuteNonQuery();
            conn.Close();
            //conn.Dispose(); Không nên giải phóng ngay vì dùng đi dùng lại nhiều
            //if(x>0)
            //{
            //    MessageBox.Show("Thanh cong roi");
            //}
        }

        private void frmHoc_Load(object sender, EventArgs e)
        {
            picBoxKhoiDong.Location = new Point(0, 23);
            picBoxKhoiDong.Size = new Size(915, 596);
            btnStart.Location = picBoxKhoiDong.Location;
            btnStart.Size = new Size(189, 123);
            lbStart.Location = new Point(51, 89);
            lbAccount.Text +=account;
            #region Tạo folder chứa câu hỏi
            //Kiểm tra xem có tồn tài folder để chứa các câu hỏi không
            //Nếu chưa tồn tại thì tạo
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            #endregion
            #region Load chủ đề vào combobox
            commstr = "Select * from dbo.func_Chude_user_duochoc(" + uiid + ")";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            sqldtreader = comm.ExecuteReader();
            while(sqldtreader.Read())
            {
                comboBox1.Items.Add(sqldtreader[0].ToString());
            }
            conn.Close();
            //conn.Dispose();
            //comm.Dispose();

            #endregion
            #region Ẩn các nút
            pictureBox1.Visible = false;
            listBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            lbtype.Visible = false;
            lbExViet.Visible = false;
            lbMean.Visible = false;
            lbpronunciation.Visible = false;
            #endregion
            #region Điền UserLearning vào bảng
            commstr = "select * from UserLearning where UIID = " + uiid;
            conn.Open();
            //dtbUserLearn = new DataTable("UserLeanring");
            dts = new DataSet();
            dad = new SqlDataAdapter(commstr, conn);
            int x = dad.Fill(dts,"UserLearning");
            conn.Close();
            conn.Dispose();
            #endregion
            comm.Dispose();
            conn.Dispose();
        }
        //int index = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btnOnTap.Text =="Next")
            {
                btnOnTap.Text = "Review";
                btnOnTap.Location = new System.Drawing.Point(42, 505);
            }
            
            
            #region Sự không thành công khi sử dụng lớp không kết nối để update
            //if(dts.HasChanges())
            //{
            //    //dtsGetChange = new DataSet();
            //    dtsGetChange = dts.GetChanges();
            //    if (dtsGetChange.HasErrors)
            //    {
            //        dts.RejectChanges();
            //    }
            //    else
            //        dad.Update(dtsGetChange,"UserLearning");
            //}
            //UpdateUserLearn(dts);
            #endregion
            dts.Clear();
            listBox1.Items.Clear();
            #region Điền các câu hỏi vào  bảng
            //Khai báo Chuỗi lấy câu hỏi trong bảng
            commstr = "select * from dbo.NhungTuChuaHoc('" + comboBox1.SelectedItem.ToString() + "'," + uiid + ")";
            conn = new SqlConnection(connstr);
            conn.Open();

            //comm = new SqlCommand(commstr, conn);
            dad = new SqlDataAdapter(commstr, conn);
            //dad.SelectCommand = comm;
            //dtb = new DataTable("QuesTionAnswer");
            total = dad.Fill(dts, "QuesTionAnswer");
            conn.Close();
            conn.Dispose();
            #endregion
            #region Ẩn 1 số 
            lbWelcome.Visible = false;
            lbLetChoss.Visible = false;
            lbEnjoy.Visible = false;
            #endregion
            #region Hiện các nút
            pictureBox1.Visible = true;
            listBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            lbtype.Visible = true;
            lbExViet.Visible = true;
            lbMean.Visible = true;
            lbpronunciation.Visible = true;
            
            btnOnTap.Visible = true;
            btnNext.Visible = true;
            btnDictionary.Visible = true;
            btnGotest.Visible = true;
            btnRememberred.Visible = true;

            btnRememberred.Enabled = true;
            btnNext.Enabled = true;
            #endregion
            
            #region insert từ vào listbox
            //Insert các từ vào listbox
            for (int i = 0; i < total; i++)
            {
                listBox1.Items.Add(dts.Tables[1].Rows[i][5].ToString());
            }
            if (total != 0)
                listBox1.SelectedIndex = 0;
            else
            {
                listBox1.Items.Add("Bạn đã học xong chủ đề này");
                listBox1.Items.Add("Hãy đi tới luyện tập,hoặc ôn tập");
                btnNext.Enabled = false;
                btnRememberred.Enabled = false;
            }
            #endregion

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnOnTap.Text == "Review")
            {
                lbpronunciation.Text = dts.Tables[1].Rows[listBox1.SelectedIndex][9].ToString();
                lbMean.Text = dts.Tables[1].Rows[listBox1.SelectedIndex][6].ToString();
                lbExViet.Text = dts.Tables[1].Rows[listBox1.SelectedIndex][7].ToString();
                lbtype.Text = dts.Tables[1].Rows[listBox1.SelectedIndex][10].ToString();
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage((byte[])dts.Tables[1].Rows[listBox1.SelectedIndex][4]);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1((string)dts.Tables[1].Rows[listBox1.SelectedIndex][1], (byte[])dts.Tables[1].Rows[listBox1.SelectedIndex][3]);
                //dtr = dtbUserLearn.NewRow();
            }
            else
            {
                lbpronunciation.Text = dts.Tables[2].Rows[listBox1.SelectedIndex][9].ToString();
                lbMean.Text = dts.Tables[2].Rows[listBox1.SelectedIndex][6].ToString();
                lbExViet.Text = dts.Tables[2].Rows[listBox1.SelectedIndex][7].ToString();
                lbtype.Text = dts.Tables[2].Rows[listBox1.SelectedIndex][10].ToString();
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage((byte[])dts.Tables[2].Rows[listBox1.SelectedIndex][4]);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1((string)dts.Tables[2].Rows[listBox1.SelectedIndex][1], (byte[])dts.Tables[2].Rows[listBox1.SelectedIndex][3]);

            }
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmDictionary dic = new frmDictionary();
            dic.Show();
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //Thu nhỏ
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            

        }
        //đăng xuất
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangnhap = new frmDangNhap();

            dangnhap.Show();
        }

        private void btnGotest_Click(object sender, EventArgs e)
        {
            Thi1 thi = new Thi1(uiid,account);
            thi.Show();
            //this.Hide();
        }
        // Xem đồ thi phát triển level
        private void map1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDothi dthi1 = new frmDothi(uiid,account);
            dthi1.StartPosition = FormStartPosition.CenterParent;
            dthi1.Show();
        }
        //Thoát
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dl==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             DialogResult dl = MessageBox.Show("Bạn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void goTeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nextLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNextLevel next = new frmNextLevel(uiid, account);
            this.Hide();
            next.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < total-1&&total!=0)
            {
                //dtr = dts.Tables[0].NewRow();
                //dtr[0] = uiid;
                //dtr[1] = (int)dts.Tables[1].Rows[listBox1.SelectedIndex][0];
                //dtr[2] = false;
                //dts.Tables[0].Rows.Add(dtr);
                InserInToUserLearning(uiid, (int)dts.Tables[1].Rows[listBox1.SelectedIndex][0]);
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            if(listBox1.SelectedIndex==total-1)
            {
                InserInToUserLearning(uiid, (int)dts.Tables[1].Rows[listBox1.SelectedIndex][0]);
                btnNext.Enabled = false;
                listBox1.Items.Clear();
                listBox1.Items.Add("Chúc mừng bạn đã hoàn thành");
                listBox1.Items.Add("chủ đề "+comboBox1.Text+" !");
                listBox1.Items.Add("Hãy tiếp tục cố gắng nhé!");
            }
            if(btnRememberred.Enabled==false)
            {
                btnRememberred.Enabled = true;
            }
        }


        private void ratingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRatings rate = new frmRatings(uiid, account);
            rate.Show();
        }

        private void btnOnTap_Click(object sender, EventArgs e)
        {
            btnRememberred.Enabled = true;
            btnOnTap.Location = new Point(42, 455);
            btnNext.Visible = false;
            //btnOnTap.Text = "Next";

            if (btnOnTap.Text == "Review")
            {
                commstr = "select * from CacCauHoiThuocChuDeThemCotRemember('" + comboBox1.Text + "'," + uiid + ")";
                conn = new SqlConnection(connstr);
                conn.Open();
                //dtb = new DataTable();
                dad = new SqlDataAdapter(commstr, conn);
                total = dad.Fill(dts, "Review");
                conn.Close();
                conn.Dispose();
                dad.Dispose();
                //Phải đặt đúng chỗ mới được ^.^
                btnOnTap.Text = "Next";

                listBox1.Items.Clear();
                if (total != 0)
                {
                    for (int i = 0; i < total; i++)
                    {
                        listBox1.Items.Add(dts.Tables[2].Rows[i][5]);
                    }
                    listBox1.SelectedIndex = 0;

                }
                else listBox1.Items.Add("Bạn chưa học chủ đề này");
            }
            else
            {

                if (total > 0&&listBox1.SelectedIndex<total-1)
                {//btnNext.PerformClick();
                    if ((bool)dts.Tables[2].Rows[listBox1.SelectedIndex+1][11])
                    {
                        btnRememberred.Enabled = false;
                    }
                    else
                        btnRememberred.Enabled = true;
                    listBox1.SelectedIndex++;
                }
            }
            //btnRememberred.Visible = false;
//                btnOnTap.Text = "Next";


            //btnNext.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            picBoxKhoiDong.Visible = false;
            lbStart.Visible = false;
            timer1.Stop();
            timer1.Enabled = false;

        }

        int x = 0, y = 0, z = 0,t=0;
        string strWel = "Welcome to learning EngLish By Pictures";
        string strLetCho = "Let's Choose Subject To Learn";
        string strEnjo = "Enjoy Your Learning!";


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (x < strWel.Length)
            {
                lbWelcome.Text += strWel[x];
                x++;
            }
            else
            {
                if (y < strLetCho.Length)
                {
                    lbLetChoss.Text += strLetCho[y];
                    y++;
                }
                else
                {
                    if (z < strEnjo.Length)
                    {
                        lbEnjoy.Text += strEnjo[z];
                        z++;
                    }
                    else
                    {
                        timer2.Stop();
                        timer2.Enabled = false;
                    }

                }
            }
        }
         private void timer1_Tick(object sender, EventArgs e)
        {
            //btnStart.Location =new Point(btnStart.Location.X+7,btnStart.Location.Y+10);
            //if (lbStart.Location.X>500)
             if(pictureBox2.Location.X>500)
            {
                #region Khi chay xong thi an anh di
                //lbStart.Location = new Point(picBoxKhoiDong.Location.X, picBoxKhoiDong.Location.Y);
                timer1.Stop();
                timer1.Enabled = false;
                picBoxKhoiDong.Visible = false;
                btnStart.Visible = false;
                lbStart.Visible = false;
                timer2.Enabled = true;
                pictureBox2.Visible = false;
                #endregion
                //timer1.Interval = 1000;
                #region Khi chay duoc 5s
                //if (t==5)
                //{
                //    timer1.Interval = 70;
                //    x = 0;
                //    if(x<strWel.Length)
                //    {
                //        lbWelcome.Text += strWel[x];
                //        x++;
                //    }
                //    else
                //    {
                //        if(y<strLetCho.Length)
                //        {
                //            lbLetChoss.Text += strLetCho[y];
                //            y++;
                //        }
                //        else
                //        {
                //            if (z < strEnjo.Length) 
                //            {
                //                lbEnjoy.Text += strEnjo[z];
                //                z++;
                //            }
                //            else
                //            {
                //                timer1.Stop();
                //                timer1.Enabled = false;
                //            }
                //        }
                //    }
                //}
                #endregion
                //t++;
            }
            //lbStart.Location = new Point(lbStart.Location.X + 40, lbStart.Location.Y + 20);
            pictureBox2.Location = new Point(pictureBox2.Location.X + 40, pictureBox2.Location.Y + 20);
            //timer1.Stop();
            //timer1.Enabled = false;
        }
        SoundPlayer ghinho = new SoundPlayer(@Application.StartupPath + @"\Data\Music\dungroi.wav");
        private void button1_Click_1(object sender, EventArgs e)
        {
            #region Lưu từ vào csdl
            if (listBox1.SelectedIndex!=-1)
            {
                if (btnOnTap.Text == "Review")
                {
                    btnRememberred.Enabled = false;
                    int IDQA = (int)dts.Tables[1].Rows[listBox1.SelectedIndex][0];
                    commstr = "Update UserLearning set ULearnRemembered = 1 where IDQA = " + IDQA;
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    comm = new SqlCommand(commstr, conn);
                    comm.ExecuteNonQuery();
                    //if (comm.ExecuteNonQuery()>0)
                    //{
                    //    MessageBox.Show("Thành công rồi nhé");
                    //}
                    conn.Close();
                    ghinho.Play();
                    conn.Dispose();
                    //conn.Dispose(); Không nên giải phóng ngay, để C# tự giải phóng đi
                    //comm.Dispose();
                    //dtr = dtb.Select("IDQA = " + IDQA);
                    //timer3.Enabled = true;
                    //timer3.Start();
                    //timer
                }
                else
                {
                    btnRememberred.Enabled = false;
                    int IDQA = (int)dts.Tables[2].Rows[listBox1.SelectedIndex][0];
                    commstr = "Update UserLearning set ULearnRemembered = 1 where IDQA = " + IDQA;
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    comm = new SqlCommand(commstr, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    ghinho.Play();
                    conn.Dispose();
                }
            }
            #endregion

        }
    }
}
