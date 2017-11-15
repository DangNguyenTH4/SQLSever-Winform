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
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Thi1 : Form
    {
        private int uiid;
        private string account;
        
        public Thi1()
        {
            InitializeComponent();
        }
        public Thi1(int uiid,string account):this()
        {
            this.uiid = uiid;
            this.account = account;
        }
        #region Khởi tạo đối tượng và chuỗi kết nối
        string connstr = @"Data Source=SMC-PC\SQLEXPRESS;Initial Catalog=ProjectBig_Sql;Integrated Security=True";
        string commstr;
        SqlConnection conn;
        SqlCommand comm;
        //DataSet dataset1;
        DataTable dtb;
        SqlDataAdapter dad;
        #endregion
        #region Khai báo các biến
        int totalQuestionInSubject;
        const int quyetDinhSoCauHoiTrongbaiThi = 20;
        //Số câu kiểm tra cần lấy là 30 câu
        int[] takenQuestions = new int[quyetDinhSoCauHoiTrongbaiThi];
        int[] takeAnswerIncorrect = new int[4]; //vị trí thứ nhất là vị trí của đáp án đúng
        int questionNumber;
        int answerTrue;
        int Vitridatdapandung;
        char[] bonvitri = { 'A', 'B', 'C', 'D' };
        Random ran ;
        #endregion
        #region thủ tục chào hỏi
        string chaohoi;
        private void loadChaoHoi()
        {
            chaohoi = "Chào " + account + " đây là phận luyện tập trí nhớ về từ vững cho bạn,\n"
                + "nó sẽ vô cùng thú vị, hãy chọn những chủ đề mà bạn cảm thấy \n vui thích để"
                + "để thử sức nhé. Fighting! ";
        }
        #endregion
        private void Thi1_Load(object sender, EventArgs e)
        {
            #region Ẩn các nút và đáp án
            rdbA.Visible = false;
            rdbB.Visible = false;
            rdbC.Visible = false;
            rdbD.Visible = false;
            picA.Visible = false;
            picB.Visible = false;
            picC.Visible = false;
            picD.Visible = false;
            //lbword.Visible = false;
            lbYeuCau.Visible = false;
            btncheck.Visible = false;
            btnNext.Visible = false;
            #endregion
            #region Chạy dòng chào hỏi
            //loadChaoHoi();
            lbUIID.Text = account;
            //timer1.Enabled = true;
            #endregion
            #region Load chu de vao combobox

            string commstring = "Select * from dbo.func_Chude_user_duochoc("+uiid+")";
            SqlDataReader dtreader;
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstring, conn);
            dtreader = comm.ExecuteReader();
            while (dtreader.Read())
            {
                comboBox1.Items.Add(dtreader.GetString(0));
            }
            dtreader.Close();
            conn.Close();
            conn.Dispose();
            #endregion

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Đếm thứ thứ tự các câu hỏi
            lbword.Text = "";
            questionNumber = 0;
            //đếm số câu hỏi đúng
            answerTrue = 0;
            //Hàm random để random câu sẽ lấy
            ran = new Random();
            //lấy ra chủ đề đã chọn
            #region Cách cũ
            //#region Kết nối với CSDL để đếm số lượng câu trong chủ đề đã chọn
            //string commstring = "select soluongcau from ChuDeSoCau where SubjectName = '" + a+"'";
            //SqlDataReader datareader;
            //conn = new SqlConnection(connectstring);
            //conn.Open();
            //comm = new SqlCommand(commstring, conn);
            //datareader = comm.ExecuteReader();
            //while (datareader.Read())
            //{
            //    totalQuestionInSubject = datareader.GetInt32(0);
            //}
            //MessageBox.Show(totalQuestionInSubject.ToString());
            //datareader.Close();
            //#endregion
            //conn.Close();
            //conn.Dispose();
            #endregion
            #region Điền các câu hỏi vào  bảng
            //Khai báo Chuỗi lấy câu hỏi trong bảng
            commstr = "select * from CacCauHoiThuocChuDe('"+Convert.ToString(comboBox1.SelectedItem)+"');";
            conn = new SqlConnection(connstr);
            conn.Open();
            
            //comm = new SqlCommand(commstr, conn);
            dad = new SqlDataAdapter(commstr,conn);
            //dad.SelectCommand = comm;
            dtb = new DataTable();
            totalQuestionInSubject = dad.Fill(dtb);
            conn.Close();
            conn.Dispose();
            #endregion
            //câu 1 sẽ lấy ở vị trí ran.next luôn
            takeAnswerIncorrect[0]=takenQuestions[0] = ran.Next(0, totalQuestionInSubject);
            #region random vị trí lấy của 3 câu sai còn lại
            //takeAnswerIncorrect = CacHamHayDung.RandomViTriLayCua3CauSai(totalQuestionInSubject, takenQuestions[0]);
            #region Đoạn này đã cho  vào trong Hàm randomvitriLaycua3CauSai roi
            for (int i = 0; i < 4; i++)
            {
                int x = 0;
                bool check = false;
                if (i != 0)
                {
                    while (check == false)
                    {
                        x = ran.Next(0, totalQuestionInSubject);
                        for (int j = 0; j < i; j++)
                        {
                            if (x == takeAnswerIncorrect[j])
                                break;
                            if (j == i - 1 && x != takeAnswerIncorrect[j])
                                check = true;
                        }
                    }
                    takeAnswerIncorrect[i] = x;
                }
            }
            #endregion
            #endregion
            lbword.Text = dtb.Rows[takeAnswerIncorrect[0]][5].ToString();
            #region Đặt các đáp án vào vị trí phù hợp
            //Xác định vị trí đặt đáp án đúng bằng cách random
            Vitridatdapandung = ran.Next(0, 4);
            //Nếu ví trí = 0 thì đáp án đúng ở A
            if(Vitridatdapandung==0)
            {
                picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
            }
            //Nếu vị trí =1 thì đáp án ở B
            if (Vitridatdapandung == 1)
            {
                picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]); //MyConvert2.ConvertBinaryToImage(QA[3].QAPicture);
            }
            //Nếu vị trí = 2 thì đáp án ở C
            if (Vitridatdapandung == 2)
            {
                picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
            }
            //Nếu vị trí =3 thì đáp án ở D
            if (Vitridatdapandung == 3)
            {
                picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
            }
            //MessageBox.Show(dtb.Rows[takeAnswerIncorrect[0]][6].ToString()+"  "+Vitridatdapandung.ToString());
            #endregion
            #region Hiển thị các hình ảnh và đáp án
            picA.Visible = true;
            picB.Visible = true;
            picC.Visible = true;
            picD.Visible = true;
            rdbA.Visible = true;
            rdbB.Visible = true;
            rdbC.Visible = true;
            rdbD.Visible = true;
            lbword.Visible = true;
            lbYeuCau.Visible = true;
            btncheck.Visible = true;
            btnNext.Visible = true;
            #endregion
            //Bắt đầu random vị trí lấy trong CSDL từ vị trí thứ 2 trở đi
            //vì vị trí 1 đã có rồi
            #region random vị trí cho các câu hỏi sắp tới
            #region Đoạn này đã được thay bằng hàm bên dưới rồi
            for (int i = 1; i < quyetDinhSoCauHoiTrongbaiThi; i++)
            {
                int x = 0;
                bool check = false;
                while (check == false)
                {
                    x = ran.Next(0, totalQuestionInSubject);
                    for (int j = 0; j < i; j++)
                    {
                        if (x == takenQuestions[j])
                            break;
                        if (j == i - 1 && x != takenQuestions[j])
                            check = true;
                    }
                }
                takenQuestions[i] = x;
            }
            #endregion
            //CacHamHayDung.RamdomCho30CauSapToi(ref takenQuestions, totalQuestionInSubject);
            #endregion 
            //Tăng số thứ tự câu hỏi lên 1
            questionNumber++;
        }
        private void KhiTraLoiXongCacCau()
        {
            //comm = new SqlCommand();
            //comm.CommandText = "select Max(UTNumerical) from UserTest where UIID =uiid and IDSubject = (select IDSubject from Subject_ where Subject_ = '" + comboBox1.Text+ "');";
            //comm.CommandText = 

            //Có vẻ như không thể thự hiện câu lệnh nếu có sự kết nối các bảng trong commstr
            //Chính vì vậy mình lại phải tạo ra một hàm dưới đây để dùng
            #region Kết nôi với csdl lấy ra số lượt đã thi của chủ đề
            commstr = "select * from SoLanThiCuaChuDe(" + uiid + ",'" + comboBox1.Text + "')";
            conn = new SqlConnection(connstr);
            conn.Open();
            //comm.Connection = conn;
            int stt=0, IDsubject=0;
            comm = new SqlCommand();
            comm.CommandText = commstr;
            comm.Connection = conn;
           // dad = new SqlDataAdapter(commstr, conn);
            //dad.Fill(dtb);
            SqlDataReader dtread;
            dtread = comm.ExecuteReader();
            //Khi người dùng chưa thi lần nào thì dtread sẽ không đọc và stt vẫn bawgnf k
            //cần xử lí
            while(dtread.Read())
            {
                //stt = Convert.ToInt32(dtb.Rows[0][1]);
                //IDsubject = Convert.ToInt32(dtb.Rows[0][0]);
                stt = Convert.ToInt32(dtread[1]) + 1;
                IDsubject = Convert.ToInt32(dtread[0]);
            }
            conn.Close();
            #endregion
            #region trường hợp đã kết nối nhưng chưa thi chủ  đề đó lần nào
            if (stt==0)
            {
                commstr = "select IDSubject from Subject_ where SubjectName = '" + comboBox1.Text + "';";
                comm.CommandText = commstr;
                conn.Open();
                comm.Connection = conn;
                IDsubject = (int)comm.ExecuteScalar();
                stt = 1;
                conn.Close();

            }
            #endregion

            //Mỗi lần kết nối chỉ sử dụng đưuọc một đối tượng sqlcommand, nên cần đóng và mở lại
            //Vậy chỉ dùng 1 đối tượng comm thôi thì sao, thử ở dưới nhé => được
            //Cần lưu ý: Mỗi lần thực hiện xong 1 câu lệnh SQL cần conn.Close() lại mới có thể thực hiện được tiếp
            #region insert lần luyện tập này vào UserTest
            conn.Open();
            commstr = "insert into UserTest values(" + uiid + "," + stt + "," + IDsubject + "," + -1+"," + answerTrue + ")";
            #region Cách này là dùng 2 đối tượng comm và comm2,
            //comm2 = new SqlCommand(comm2str, conn);
            //int x = comm2.ExecuteNonQuery();
            #endregion
            //Chỉ sử dụng 1 đối tượng comm
            comm.CommandText = commstr;
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            comm.Dispose();
            //comm2.Dispose();
            #endregion
        }
        SoundPlayer dungroi = new SoundPlayer(@Application.StartupPath + @"\Data\Music\dungroi.wav");
        SoundPlayer sairoi = new SoundPlayer(@Application.StartupPath + @"\Data\Music\sairoi.wav");
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked == false && rdbB.Checked == false && rdbC.Checked == false && rdbD.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn đáp án");
            }
            else
            {


                #region Kiểm tra xem có chọn đúng đáp án không
                if (Vitridatdapandung == 0 && rdbA.Checked == true)
                {
                    answerTrue++;
                    dungroi.Play();


                }
                else if (Vitridatdapandung == 1 && rdbB.Checked == true)
                {
                    answerTrue++;
                    dungroi.Play();
                }
                else if (Vitridatdapandung == 2 && rdbC.Checked == true)
                {
                    dungroi.Play();
                    answerTrue++;
                }
                else if (Vitridatdapandung == 3 && rdbD.Checked == true)
                {
                    answerTrue++;
                    dungroi.Play();
                }
                else sairoi.Play();
                #endregion
                #region Khi luyện tập đủ số câu
                if (questionNumber == quyetDinhSoCauHoiTrongbaiThi)
                {
                    btnNext.Visible = false;
                    MessageBox.Show("Bạn làm đúng : " + answerTrue + "/"+quyetDinhSoCauHoiTrongbaiThi+" câu.");
                    KhiTraLoiXongCacCau();
                    //commstr= "insert into UserLearning values("
                }
                #endregion
                #region Đang luyện tập
                else
                {
                    lbword.Text = dtb.Rows[takenQuestions[questionNumber]][5].ToString();
                    #region xác định các vị trí lấy của 4 đáp án
                    takeAnswerIncorrect[0] = takenQuestions[questionNumber];

                    for (int i = 0; i < 4; i++)
                    {
                        int x = 0;
                        bool check = false;
                        if (i != 0)
                        {
                            while (check == false)
                            {
                                x = ran.Next(0, totalQuestionInSubject);
                                for (int j = 0; j < i; j++)
                                {
                                    if (x == takeAnswerIncorrect[j])
                                        break;
                                    if (j == i - 1 && x != takeAnswerIncorrect[j])
                                        check = true;
                                }
                            }
                            takeAnswerIncorrect[i] = x;
                        }
                    }
                    #endregion
                    #region Random tìm vị trí đáp án đúng
                    Vitridatdapandung = ran.Next(0, 4);
                    //Nếu ví trí = 0 thì đáp án đúng ở A
                    if (Vitridatdapandung == 0)
                    {
                        picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                        picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                        picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                        picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
                    }
                    //Nếu vị trí =1 thì đáp án ở B
                    if (Vitridatdapandung == 1)
                    {
                        picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                        picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                        picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                        picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]); //MyConvert2.ConvertBinaryToImage(QA[3].QAPicture);
                    }
                    //Nếu vị trí = 2 thì đáp án ở C
                    if (Vitridatdapandung == 2)
                    {
                        picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                        picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                        picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                        picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
                    }
                    //Nếu vị trí =3 thì đáp án ở D
                    if (Vitridatdapandung == 3)
                    {
                        picD.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[0]][4]);
                        picB.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[1]][4]);
                        picC.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[2]][4]);
                        picA.Image = MyConvert2.ConvertBinaryToImage((byte[])dtb.Rows[takeAnswerIncorrect[3]][4]);
                    }
                    #endregion
                    questionNumber++;
                }
                #endregion
            }
        }
        #region Cài đặt khi click vào ảnh cũng là chọn đáp án
        private void picA_Click(object sender, EventArgs e)
        {
            rdbA.Checked = true;
            WhenClickThePictureA();
        }

        private void picB_Click(object sender, EventArgs e)
        {
            rdbB.Checked = true;
            WhenClickThePictureB();

        }

        private void picC_Click(object sender, EventArgs e)
        {
            rdbC.Checked = true;
            WhenClickThePictueC();
        }

        private void picD_Click(object sender, EventArgs e)
        {
            rdbD.Checked = true;
            WhenClickThePictureD();
        }
        #endregion
        //Hơi thừa nhưng ksao
        #region click anhr nao thi anh do thay doi!!
        private void WhenClickThePictureA()
        {
            {
                picA.BorderStyle = BorderStyle.Fixed3D;
                picB.BorderStyle = BorderStyle.None;
                picC.BorderStyle = BorderStyle.None;
                picD.BorderStyle = BorderStyle.None;
            }
        }
        private void WhenClickThePictureB()
        {
            {
                picB.BorderStyle = BorderStyle.Fixed3D;
                picA.BorderStyle = BorderStyle.None;
                picC.BorderStyle = BorderStyle.None;
                picD.BorderStyle = BorderStyle.None;
            }
        }
        private void WhenClickThePictueC()
        {
            picC.BorderStyle = BorderStyle.Fixed3D;
            picB.BorderStyle = BorderStyle.None;
            picA.BorderStyle = BorderStyle.None;
            picD.BorderStyle = BorderStyle.None;
        }
        private void WhenClickThePictureD() 
        {
                picD.BorderStyle = BorderStyle.Fixed3D;
                picB.BorderStyle = BorderStyle.None;
                picC.BorderStyle = BorderStyle.None;
                picA.BorderStyle = BorderStyle.None;
        }
        #endregion
        int demChaohoi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(demChaohoi<chaohoi.Length)
            {
                lbword.Text += chaohoi[demChaohoi];
                demChaohoi++;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 