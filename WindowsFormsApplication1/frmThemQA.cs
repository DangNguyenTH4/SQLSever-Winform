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
    public partial class frmThemQA : Form
    {
        public frmThemQA()
        {
            InitializeComponent();
        }
        string commstr;
        string connstr = @"Data Source=SMC-PC\SQLEXPRESS;Initial Catalog=ProjectBig_Sql;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        int Idsubject = -1;
        int IDQA = -1;
        async private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            #region Sử dụng thủ tục insert QA tự tạo QACode
            //byte[] hinhanh = MyConvert2.ConvertImageToBinary(txtFilenamePicture.Text);
            //byte[] amthanh = MyConvert2.ConvertMediaToBinary(txtFilenameSound.Text);
            //conn = new SqlConnection(connstr);
            //conn.Open();
            //commstr = "exec InsertQA '" + cbboxSubject.Text + "','" +
            //                            amthanh + "','"
            //                            + hinhanh + "','"
            //                            + txtEngWordPicture.Text + "','"
            //                            + txtVietWordPicture.Text + "','"
            //                            + txtExampleViet.Text + "','"
            //                            + txtExampleEng.Text + "','"
            //                            + txtPronunciation.Text + "','"
            //                            + txtTypeWord.Text + "'";
            //comm = new SqlCommand(commstr, conn);
            //if(comm.ExecuteNonQuery()>0)
            //{
            //    MessageBox.Show("Insert Successfully!");
            //}
            //else
            //{
            //    MessageBox.Show("Insert Fail!");
            //}
            //conn.Close();
            //conn.Dispose();
            //comm.Dispose();
            #endregion


            try
            {
                using (ProjectBig_SqlEntities2 Pro = new ProjectBig_SqlEntities2())
                {

                    QuestionAnswer QA = new QuestionAnswer()
                    {
                        QACode = lbCodeOfWord.Text,
                        IDSubject = this.Idsubject,
                        QASound = MyConvert2.ConvertMediaToBinary(txtFilenameSound.Text),
                        QAPicture = MyConvert2.ConvertImageToBinary(txtFilenamePicture.Text),
                        QAEngWord = txtEngWordPicture.Text,
                        QAVietWord = txtVietWordPicture.Text,
                        QAExample_Viet = txtExampleViet.Text,
                        QAExample_Eng = txtExampleEng.Text,
                        QAPronunciation = txtPronunciation.Text,
                        TypeOfWord = txtTypeWord.Text
                    };
                    Pro.QuestionAnswers.Add(QA);
                    await Pro.SaveChangesAsync();
                    MessageBox.Show("You have been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IDQA++;

                    lbCodeOfWord.Text = cbboxSubject.Text + IDQA.ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnChooseSound_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] filename = CutOrSplitOrJoinOrFormat.CutTheExtensions(ofd.SafeFileName).Split('+');
                    txtFilenameSound.Text = ofd.FileName;
                    txtWordSound.Text = filename[0];
                    txtPronunciation.Text = "/" + filename[1] + "/";
                    axWindowsMediaPlayer1.URL = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    string[] filename = CutOrSplitOrJoinOrFormat.CutTheExtensions(ofd.SafeFileName).Split('+');
                    txtEngWordPicture.Text = filename[0];
                    txtTypeWord.Text = filename[1];
                    txtVietWordPicture.Text = filename[2];
                    pic1.Image = Image.FromFile(ofd.FileName);
                    txtFilenamePicture.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmThemQA_Load(object sender, EventArgs e)
        {
            cbboxSubject.Items.Clear();
            commstr = "select  SubjectName from Subject_";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            SqlDataReader dtread = comm.ExecuteReader();
            while(dtread.Read())
            {
                cbboxSubject.Items.Add(dtread[0]);
            }
            conn.Close();
            conn.Dispose();
            comm.Dispose();
        }

        private void cbboxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            commstr = "select IDSubject, Max(IDQA) from QuestionAnswer "
                       + " where IDSubject = (select IDSubject from Subject_"
                                             + " where SubjectName = '" + cbboxSubject.Text + "')"
                                             + " group by IDSubject";
            Idsubject = -1;
            IDQA = -1;
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            SqlDataReader dtr = comm.ExecuteReader();
            while(dtr.Read())
            {
                Idsubject = (int)dtr[0];
                IDQA = (int)dtr[1]+1;
                lbCodeOfWord.Text = cbboxSubject.Text.Trim() + IDQA.ToString();
            }
            conn.Close();

            if (Idsubject==-1)
            {
                commstr = "select IDSubject  from Subject_ where SubjectName = '" + cbboxSubject.Text + "';";
                conn.Open();
                comm = new SqlCommand(commstr, conn);
                Idsubject = (int)comm.ExecuteScalar();
                IDQA = 1;
                lbCodeOfWord.Text = cbboxSubject.Text.Trim() + IDQA.ToString();
                conn.Close();
            }
            conn.Dispose();

        }
    }
}
