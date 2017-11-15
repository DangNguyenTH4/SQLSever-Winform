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
    public partial class frmNextLevel : Form 
    {
        int uiid;
        string account;
        public frmNextLevel()
        {
            InitializeComponent();
        }

        public frmNextLevel(int uiid,string account):this()
        {
            this.uiid = uiid;
            this.account = account;
        }

        #region Khai báo đối tượng và chuỗi để kết nối csdl
        SqlCommand comm;
        SqlConnection conn;
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL; Integrated Security = true;";
        string commstr;
        SqlDataAdapter dad;
        DataTable dtb;
        int IDSubJectNextLevel = 30;
        #endregion
        #region Khai báo đối tượng form thi
        frmforNext1 next1;
        frmfornext2 next2;
        frmFornext3 next3;
        frmFornext4 next4;
        frmforNext5 next5;
        frmforNext6 next6;
        #endregion
        #region Khai báo các biến cần dùng khi  thi
        int sttCauHoi = 0, answerTrue = 0, quyetdinhSoCauThi = 30, totalQuesTion = 0,sttcautruoc=0;
        int[] mangCacCauHoiDuocChon, bonDapAn;
        int[] mangluuvitridungcuacaccauhoi;
        int motTrong4vitridung = 1;
        int diemThi = 0;
        int SoLuongFormMuonTaoDeThi = 6;
        int z = 0, ZTru1 = 0; //z là số trả về khi random để chọn loại form thi, ZTru1 là z ở câu hỏi ngay trước đó
        Random ran;
        #endregion
        #region Khởi tạo các đối tượng âm thanh Đúng, Sai, Bắt đầu...
        SoundPlayer dungroi = new SoundPlayer(@Application.StartupPath + @"\Data\Music\dungroi.wav");
        SoundPlayer sairoi = new SoundPlayer(@Application.StartupPath + @"\Data\Music\sairoi.wav");
        SoundPlayer batdau = new SoundPlayer(@Application.StartupPath + @"\Data\Music\begin.wav");
        #endregion
        private void frmNextLevel_Load(object sender, EventArgs e)
        {
            #region Khởi động nhạc bắt đầu và load hướng dẫn
            batdau.Play();
            loadhuongdan();
            timer2.Enabled = true;
            #endregion
            btntieptuc.Enabled = false;
            #region Điền các nguồn câu hỏi vào DataTable
            commstr = "select * from CacCauHoiCungCapDoCuaNguoiDung(" + uiid + ")";
            conn = new SqlConnection(connstr);
            conn.Open();
            dad = new SqlDataAdapter(commstr, conn);
            dtb = new DataTable();
            totalQuesTion = dad.Fill(dtb);
            conn.Close();
            #endregion
            //Chọn ra 30(quyetdinhSoCauThi) câu hỏi sẽ thi, trong tổng số (totalQuesTion) câu hỏi
            if (totalQuesTion > 0)
            {
                mangCacCauHoiDuocChon = MyRandom.RandomViTriLayCauHoi(totalQuesTion, quyetdinhSoCauThi);
            //Khởi tạo mạng để luu vị trí các đáp án đúng khi random
                mangluuvitridungcuacaccauhoi = new int[quyetdinhSoCauThi];
                #region Khởi tạo form các loại hình thi
            next1 = new frmforNext1();
            next2 = new frmfornext2();
            next3 = new frmFornext3();
            next4 = new frmFornext4();
            next5 = new frmforNext5();
            next6 = new frmforNext6();
            next1.TopLevel = false;
            next2.TopLevel = false;
            next3.TopLevel = false;
            next4.TopLevel = false;
            next5.TopLevel = false;
            next6.TopLevel = false;

            next1.FormBorderStyle = FormBorderStyle.None;
            next2.FormBorderStyle = FormBorderStyle.None;
            next3.FormBorderStyle = FormBorderStyle.None;
            next4.FormBorderStyle = FormBorderStyle.None;
            next6.FormBorderStyle = FormBorderStyle.None;
            next5.FormBorderStyle = FormBorderStyle.None;

            next1.Dock = DockStyle.Fill;
            next2.Dock = DockStyle.Fill;
            next3.Dock = DockStyle.Fill;
            next4.Dock = DockStyle.Fill;
            next6.Dock = DockStyle.Fill;
            next5.Dock = DockStyle.Fill;
            #endregion
                #region add vào panel
            panel1.Controls.Add(next1);
            panel1.Controls.Add(next2);
            panel1.Controls.Add(next3);
            panel1.Controls.Add(next4);
            panel1.Controls.Add(next5);
            panel1.Controls.Add(next6);
            #endregion
                //next1.Show();
            }
        }
        #region Load dòng chữ hướng dẫn
        string huongdan;
        int demkytu = 0;
        private void loadhuongdan()
        {
            huongdan = account +" thân mến!\nĐây là phần thi quan trọng quyết định bạn \ncó thể chuyển sang cấp độ mới hay không.\n"
                    + "Bạn sẽ phải làm " + quyetdinhSoCauThi + " câu hỏi, \nvới thời lượng tối đa là " + thoigiantraloi + " cho mỗi "
                    + "câu.\nHãy bình tĩnh vượt qua nhé.\nChúc bạn thành công!\nGiờ hãy bắt đầu thôi!";
            //lbhuongdan.ForeColor = Color.AliceBlue;

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(demkytu<huongdan.Length)
            {
                lbhuongdan2.Text += huongdan[demkytu];
                demkytu++;
            }
            else
            {
                timer2.Stop();
                timer2.Enabled = false;
            }
        }
        #endregion
        int SoLanThi = 1;
        int CapDo = 1;
        int thoiGianConLai = 0;
        private int TinhDiemThi(int thoiGianConLai,int sttCauhoi)
        {
            int diemthi = 0;
            if (thoiGianConLai > 0)
                diemthi = thoiGianConLai * sttCauhoi;
            else diemThi = sttCauhoi;
            return diemthi;
        }

        private void frmNextLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btntieptuc.PerformClick();
            }
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            //btntieptuc.PerformClick();
        }

        internal void trovaonext()
        {
            ActiveControl = btntieptuc;
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = btntieptuc;
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {
            #region khi trả lời xong 30 câu hỏi
            if (sttCauHoi == quyetdinhSoCauThi)
            {
                thoiGianConLai = thoigiantraloi;
                btntieptuc.Enabled = false;
                //timer1.Stop();
                timer1.Enabled = false;
                #region Kiem tra xem chon dap an dung khong
                if (ZTru1 == 1)
                {
                    if (next1.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 2)
                {
                    if (next2.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();

                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 3)//z=z-z+3
                {
                    if (next3.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 4)//z=z-z+4.....z=z-z+z
                {
                    if (next4.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 5)
                {
                    if (next5.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 6)
                {
                    if (next6.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                #endregion
                #region Kết nối với CSDL lấy ra cấp độ hiện tại và số lần đã thi chuyển cấp
                commstr = "select * from  dbo.SoLanThiCuaChuyenCap1(" + uiid + ");";
                conn = new SqlConnection(connstr);
                conn.Open();
                comm = new SqlCommand(commstr, conn);
                SqlDataReader dtread = comm.ExecuteReader();
                while(dtread.Read())
                {
                    SoLanThi = (int)(dtread[0])+1;
                    CapDo = (int)(dtread[1]);
                }
                conn.Close();
                #endregion
                #region Kết nối với CSDL insert lượt thi vừa rồi vào bảng thi
                commstr = "insert UserTest values(" + uiid + "," + SoLanThi  + "," + IDSubJectNextLevel + "," + CapDo + ","
                    + diemThi + ");";
                conn.Open();
                comm.CommandText = commstr;
                comm.Connection = conn;
                comm.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                #endregion
                MessageBox.Show("dung " +answerTrue+"\nĐạt được: "+diemThi);
                

            }
            #endregion
            #region Trong khi trả lời các câu hoi: 1-30
            else
            {
                #region Khởi động lại thời gian và thứ khác
                thoiGianConLai = thoigiantraloi;
                thoigiantraloi = 10;
                lbthoigiantraloi.ForeColor = Color.Sienna;
                timer1.Enabled = true;
                #endregion
                #region Kiem tra xem chon dap an dung khong
                if (ZTru1 == 1)
                {
                    if (next1.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                        diemThi+=TinhDiemThi(thoiGianConLai,sttcautruoc);
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 2)
                {
                    if (next2.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();

                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 3)//z=z-z+3
                {
                    if (next3.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 4)//z=z-z+4.....z=z-z+z
                {
                    if (next4.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 5)
                {
                    if (next5.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }
                if (ZTru1 == 6)
                {
                    if (next6.kiemtraXemChonDungKhong(mangluuvitridungcuacaccauhoi[sttcautruoc]))
                    {
                        diemThi += TinhDiemThi(thoiGianConLai, sttcautruoc);
                        answerTrue++;
                        lbSocauDung.Text = answerTrue.ToString();
                        dungroi.Play();
                    }
                    else
                    {
                        sairoi.Play();
                        lbSocausai.Text = (Convert.ToInt16(lbSocausai.Text) + 1).ToString();
                    }
                }

                #endregion
                #region Khởi tạo một câu hỏi mới
                //Xóa các controls(fomr cũ( hiện tại của panel -> để nạp control(form) mới
                this.panel1.Controls.Clear();
                //random để chọn form tiếp theo được nạp vào panel
                ran = new Random();
                z = ran.Next(1,7);
                //Lưu trữ z -> Ztru1 để sang câu sau thì kiểm tra xem chọn đáp án đúng không
                ZTru1 = z;
                //Random 3 vị trí còn lại cần phải lấy ra trong datatable để nạp vào form
                bonDapAn = MyRandom.random3vitriconlai(mangCacCauHoiDuocChon[sttCauHoi], totalQuesTion);
                //random để chọn ra vị trí sẽ đặt đáp án đúng vào đó
                motTrong4vitridung = MyRandom.random1trong4vitridung();
                //lưu lại vị trí đúng để sau khi bấm next thì kiểm tra xem đáp án có đúng không
                mangluuvitridungcuacaccauhoi[sttCauHoi] = motTrong4vitridung;
                #endregion
                #region load form va cau hoi vao form
                if (z == 1)
                {
                    panel1.Controls.Add(next1);
                    next1.Show();
                    next2.Hide();
                    next3.Hide();
                    next4.Hide();
                    next5.Hide();
                    next6.Hide();
                    next1.bochontatca();
                    next1.loadCacThuVao(motTrong4vitridung, 
                                        (byte[])dtb.Rows[bonDapAn[0]][4],
                                        (byte[])dtb.Rows[bonDapAn[1]][4], 
                                        (byte[])dtb.Rows[bonDapAn[2]][4], 
                                        (byte[])dtb.Rows[bonDapAn[3]][4],
                                        (string)dtb.Rows[bonDapAn[0]][1], 
                                        (byte[])dtb.Rows[bonDapAn[0]][3]);
                    
                }
                if (z == 2)
                {

                    panel1.Controls.Add(next2);
                    next2.Show();
                    next1.Hide();
                    next3.Hide();
                    next4.Hide();
                    next5.Hide();
                    next6.Hide();
                    next2.bochontatca();
                    next2.loadCacThuVao(motTrong4vitridung, 
                                         dtb.Rows[bonDapAn[0]][5].ToString(),
                                         dtb.Rows[bonDapAn[1]][5].ToString(), 
                                         (string)dtb.Rows[bonDapAn[2]][5],
                                         dtb.Rows[bonDapAn[3]][5].ToString(), 
                                         dtb.Rows[bonDapAn[0]][1].ToString(),
                                         (byte[])dtb.Rows[bonDapAn[0]][3]);
                }
                if (z == 3)
                {

                    panel1.Controls.Add(next3);
                    next3.Show();
                    next2.Hide();
                    next1.Hide();
                    next4.Hide();
                    next5.Hide();
                    next6.Hide();
                    next3.bochontatca();
                    next3.loadCacThuVao(motTrong4vitridung, 
                                        (byte[])dtb.Rows[bonDapAn[0]][4], 
                                        (byte[])dtb.Rows[bonDapAn[0]][3],
                                        (byte[])dtb.Rows[bonDapAn[1]][3], 
                                        (byte[])dtb.Rows[bonDapAn[2]][3], 
                                        (byte[])dtb.Rows[bonDapAn[3]][3],
                                        dtb.Rows[bonDapAn[0]][1].ToString(), 
                                        dtb.Rows[bonDapAn[1]][1].ToString(), 
                                        dtb.Rows[bonDapAn[2]][1].ToString(),
                                        dtb.Rows[bonDapAn[3]][1].ToString());
                }
                if (z == 4)
                {

                    panel1.Controls.Add(next4);
                    next4.Show();
                    next2.Hide();
                    next3.Hide();
                    next1.Hide();
                    next5.Hide();
                    next6.Hide();
                    next4.bochontatca();
                    next4.loadCacThuVao(motTrong4vitridung,
                                            (string)dtb.Rows[bonDapAn[0]][9],
                                            (string)dtb.Rows[bonDapAn[1]][9], 
                                            (string)dtb.Rows[bonDapAn[2]][9],
                                            (string)dtb.Rows[bonDapAn[3]][9],
                                            (string)dtb.Rows[bonDapAn[0]][1],
                                            (byte[])dtb.Rows[bonDapAn[0]][4],
                                            (byte[])dtb.Rows[bonDapAn[0]][3]);
                }
                if (z == 5)
                {

                    panel1.Controls.Add(next5);
                    next5.Show();
                    next6.Hide();
                    next4.Hide();
                    next3.Hide();
                    next2.Hide();
                    next1.Hide();
                    next5.loadCacThuVao(motTrong4vitridung,
                                        (string)dtb.Rows[bonDapAn[0]][5],
                                        (byte[])dtb.Rows[bonDapAn[0]][4],
                                        (byte[])dtb.Rows[bonDapAn[1]][4],
                                        (byte[])dtb.Rows[bonDapAn[2]][4],
                                        (byte[])dtb.Rows[bonDapAn[3]][4]);

                }
                if (z == 6)
                {
                    panel1.Controls.Add(next6);

                    next6.Show();
                    next2.Hide();
                    next3.Hide();
                    next4.Hide();
                    next1.Hide();
                    next5.Hide();
                    next6.bochontatca();
                    next6.loadCacThuVao(motTrong4vitridung, 
                                        (byte[])dtb.Rows[bonDapAn[0]][4], 
                                        dtb.Rows[bonDapAn[0]][5].ToString(), 
                                        (string)dtb.Rows[bonDapAn[1]][5],
                                        dtb.Rows[bonDapAn[2]][5].ToString(), 
                                        dtb.Rows[bonDapAn[3]][5].ToString());

                    
                }

                #endregion
                #region dat cau hoi vao form không dùng nữa
                //if (z == 1)
                //{
                //    next1.bochontatca();
                //    next1.loadCacThuVao(motTrong4vitridung, (byte[])dtb.Rows[bonDapAn[0]][4],
                //                        (byte[])dtb.Rows[bonDapAn[1]][4], (byte[])dtb.Rows[bonDapAn[2]][4], (byte[])dtb.Rows[bonDapAn[3]][4],
                //                        (string)dtb.Rows[bonDapAn[0]][1], (byte[])dtb.Rows[bonDapAn[0]][3]);
                //}
                //if (z == 2)
                //{
                //    next2.bochontatca();
                //    next2.loadCacThuVao(motTrong4vitridung, dtb.Rows[bonDapAn[0]][5].ToString(),
                //                         dtb.Rows[bonDapAn[1]][5].ToString(), (string)dtb.Rows[bonDapAn[2]][5],
                //                         dtb.Rows[bonDapAn[3]][5].ToString(), dtb.Rows[bonDapAn[0]][1].ToString(),
                //                         (byte[])dtb.Rows[bonDapAn[0]][3]);
                //}
                //if (z == 3)
                //{
                //    next3.bochontatca();
                //    next3.loadCacThuVao(motTrong4vitridung, (byte[])dtb.Rows[bonDapAn[0]][4], (byte[])dtb.Rows[bonDapAn[0]][3],
                //                        (byte[])dtb.Rows[bonDapAn[1]][3], (byte[])dtb.Rows[bonDapAn[2]][3], (byte[])dtb.Rows[bonDapAn[3]][3],
                //                        dtb.Rows[bonDapAn[0]][1].ToString(), dtb.Rows[bonDapAn[1]][1].ToString(), dtb.Rows[bonDapAn[2]][1].ToString(),
                //                        dtb.Rows[bonDapAn[3]][1].ToString());
                //}
                //if (z == 4)
                //{
                //    next4.bochontatca();
                //    next4.loadCacThuVao(motTrong4vitridung, (string)dtb.Rows[bonDapAn[0]][9],
                //                        (string)dtb.Rows[bonDapAn[1]][9], (string)dtb.Rows[bonDapAn[2]][9],
                //                        (string)dtb.Rows[bonDapAn[3]][9], (string)dtb.Rows[bonDapAn[0]][1],
                //                        (byte[])dtb.Rows[bonDapAn[0]][4], (byte[])dtb.Rows[bonDapAn[0]][3]);

                //}
                #endregion
                //tăng stt câu hỏi lên 1
                sttcautruoc = sttCauHoi; // cái này hơi thừa
                sttCauHoi++;
            }
            #endregion
        }
        #region Đếm ngược thời gian trả lời câu hỏi
        int thoigiantraloi = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(thoigiantraloi==3)
            {
                lbthoigiantraloi.ForeColor = Color.Red;
            }
            if(thoigiantraloi==0-1)
            {
                thoigiantraloi = 10;
                timer1.Stop();
                btntieptuc_Click(sender, e);
            }
            lbthoigiantraloi.Text = thoigiantraloi.ToString();
            thoigiantraloi--;

        }
        #endregion



        private void lbSocausai_Click(object sender, EventArgs e)
        {

        }

        private void btnbatdau_Click(object sender, EventArgs e)
        {
           // if (totalQuesTion > 0)
            {
                timer1.Enabled = true;
                //this.BackColor = Color.White;
                sttCauHoi = 0;
                #region visiable các thứ
                panel1.Location = new System.Drawing.Point(0, 0);
                panel1.Size = new System.Drawing.Size(513, 477);
                btntieptuc.Enabled = true;
                btntieptuc.Visible = true;
                panel1.Visible = true;
                lbSocauDung.Visible = true;
                lbSocausai.Visible = true;
                lbthoigiantraloi.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                btnbatdau.Visible = false;
                lbhuongdan2.Visible = false;
                //this.BackgroundImage = BackgroundImage.Prop
                #endregion
                this.panel1.Controls.Clear();
                ran = new Random();
                z = ran.Next(1, 7);//+1 chuaw cho +1 vao vi dang bi thieu phien am
                ZTru1 = z;
                bonDapAn = MyRandom.random3vitriconlai(mangCacCauHoiDuocChon[sttCauHoi], totalQuesTion);
                motTrong4vitridung = ran.Next(1, 5);//MyRandom.random1trong4vitridung();
                mangluuvitridungcuacaccauhoi[sttCauHoi] = motTrong4vitridung;

                #region load form len panel
                if (z == 1)
                {
                    panel1.Controls.Add(next1);
                    next1.Show();
                    next2.Hide();
                    next3.Hide();
                    next4.Hide();
                    next6.Hide();
                    next5.Hide();
                    next1.loadCacThuVao(motTrong4vitridung,
                                        (byte[])dtb.Rows[bonDapAn[0]][4],
                                        (byte[])dtb.Rows[bonDapAn[1]][4],
                                        (byte[])dtb.Rows[bonDapAn[2]][4],
                                        (byte[])dtb.Rows[bonDapAn[3]][4],
                                        (string)dtb.Rows[bonDapAn[0]][1],
                                        (byte[])dtb.Rows[bonDapAn[0]][3]);
                }
                if (z == 2)
                {

                    panel1.Controls.Add(next2);
                    next2.Show();
                    next1.Hide();
                    next3.Hide();
                    next4.Hide();
                    next6.Hide();
                    next5.Hide();
                    next2.loadCacThuVao(motTrong4vitridung,
                                      dtb.Rows[bonDapAn[0]][5].ToString(),
                                      dtb.Rows[bonDapAn[1]][5].ToString(),
                                      (string)dtb.Rows[bonDapAn[2]][5],
                                      dtb.Rows[bonDapAn[3]][5].ToString(),
                                      dtb.Rows[bonDapAn[0]][1].ToString(),
                                      (byte[])dtb.Rows[bonDapAn[0]][3]);
                }
                if (z == 3)
                {

                    panel1.Controls.Add(next3);
                    next3.Show();
                    next2.Hide();
                    next1.Hide();
                    next4.Hide();
                    next6.Hide();
                    next5.Hide();
                    next3.loadCacThuVao(motTrong4vitridung,
                                    (byte[])dtb.Rows[bonDapAn[0]][4],
                                    (byte[])dtb.Rows[bonDapAn[0]][3],
                                    (byte[])dtb.Rows[bonDapAn[1]][3],
                                    (byte[])dtb.Rows[bonDapAn[2]][3],
                                    (byte[])dtb.Rows[bonDapAn[3]][3],
                                    dtb.Rows[bonDapAn[0]][1].ToString(),
                                    dtb.Rows[bonDapAn[1]][1].ToString(),
                                    dtb.Rows[bonDapAn[2]][1].ToString(),
                                    dtb.Rows[bonDapAn[3]][1].ToString());
                }
                if (z == 4)
                {

                    panel1.Controls.Add(next4);
                    next4.Show();
                    next2.Hide();
                    next3.Hide();
                    next1.Hide();
                    next6.Hide();
                    next5.Hide();
                    next4.loadCacThuVao(motTrong4vitridung,
                                      (string)dtb.Rows[bonDapAn[0]][9],
                                      (string)dtb.Rows[bonDapAn[1]][9],
                                      (string)dtb.Rows[bonDapAn[2]][9],
                                      (string)dtb.Rows[bonDapAn[3]][9],
                                      (string)dtb.Rows[bonDapAn[0]][1],
                                      (byte[])dtb.Rows[bonDapAn[0]][4],
                                      (byte[])dtb.Rows[bonDapAn[0]][3]);
                }
                if (z == 5)
                {

                    panel1.Controls.Add(next5);
                    next5.Show();
                    next6.Hide();
                    next4.Hide();
                    next3.Hide();
                    next2.Hide();
                    next1.Hide();
                    next5.loadCacThuVao(motTrong4vitridung,
                                        (string)dtb.Rows[bonDapAn[0]][5],
                                        (byte[])dtb.Rows[bonDapAn[0]][4],
                                        (byte[])dtb.Rows[bonDapAn[1]][4],
                                        (byte[])dtb.Rows[bonDapAn[2]][4],
                                        (byte[])dtb.Rows[bonDapAn[3]][4]);

                }
                if (z == 6)
                {
                    panel1.Controls.Add(next6);

                    next6.Show();
                    next2.Hide();
                    next3.Hide();
                    next4.Hide();
                    next1.Hide();
                    next5.Hide();
                    next6.bochontatca();
                    next6.loadCacThuVao(motTrong4vitridung,
                                        (byte[])dtb.Rows[bonDapAn[0]][4],
                                        dtb.Rows[bonDapAn[0]][5].ToString(),
                                        (string)dtb.Rows[bonDapAn[1]][5],
                                        dtb.Rows[bonDapAn[2]][5].ToString(),
                                        dtb.Rows[bonDapAn[3]][5].ToString());


                }
                #endregion
                #region load cau hoi len form
                //if (z == 1)
                //{
                //    next1.loadCacThuVao(motTrong4vitridung, (byte[])dtb.Rows[bonDapAn[0]][4],
                //                        (byte[])dtb.Rows[bonDapAn[1]][4], (byte[])dtb.Rows[bonDapAn[2]][4], (byte[])dtb.Rows[bonDapAn[3]][4],
                //                        (string)dtb.Rows[bonDapAn[0]][1], (byte[])dtb.Rows[bonDapAn[0]][3]);
                //}
                //if (z == 2)
                //{
                //    next2.loadCacThuVao(motTrong4vitridung, dtb.Rows[bonDapAn[0]][5].ToString(),
                //                         dtb.Rows[bonDapAn[1]][5].ToString(), (string)dtb.Rows[bonDapAn[2]][5],
                //                         dtb.Rows[bonDapAn[3]][5].ToString(), dtb.Rows[bonDapAn[0]][1].ToString(),
                //                         (byte[])dtb.Rows[bonDapAn[0]][3]);
                //}
                //if (z == 3)
                //{
                //    next3.loadCacThuVao(motTrong4vitridung, (byte[])dtb.Rows[bonDapAn[0]][4], (byte[])dtb.Rows[bonDapAn[0]][3],
                //                        (byte[])dtb.Rows[bonDapAn[1]][3], (byte[])dtb.Rows[bonDapAn[2]][3], (byte[])dtb.Rows[bonDapAn[3]][3],
                //                        dtb.Rows[bonDapAn[0]][1].ToString(), dtb.Rows[bonDapAn[1]][1].ToString(), dtb.Rows[bonDapAn[2]][1].ToString(),
                //                        dtb.Rows[bonDapAn[3]][1].ToString());
                //}
                //if (z == 4)
                //{
                //    next4.loadCacThuVao(motTrong4vitridung, (string)dtb.Rows[bonDapAn[0]][9],
                //                        (string)dtb.Rows[bonDapAn[1]][9], (string)dtb.Rows[bonDapAn[2]][9],
                //                        (string)dtb.Rows[bonDapAn[3]][9], (string)dtb.Rows[bonDapAn[0]][1],
                //                        (byte[])dtb.Rows[bonDapAn[0]][4], (byte[])dtb.Rows[bonDapAn[0]][3]);
                //}
                #endregion
                sttcautruoc = sttCauHoi;
                sttCauHoi++;
            }
        }

        private void loadForNext1(int sttCau,int vitrilay)
        {
            
        }
    }
}
