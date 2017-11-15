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
    public partial class frmQuanlinguoidung : Form
    {
        public frmQuanlinguoidung()
        {
            InitializeComponent();
        }
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL;Integrated Security = true;";
        string commstr;
        //SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter dad;
        DataTable dtb;
        DataSet dts;
        SqlCommand comm;
        private void btntaikhoannguoidung_Click(object sender, EventArgs e)
        {
            lstV.Visible = true;
            btnTrove.Visible = true;


        }

        internal void btnTrove_Click(object sender, EventArgs e)
        {

            btnTrove.Visible = false;
            if(lstV.Visible==true)
                lstV.Visible = false;

            if (dataGridQuaTrinhTangCap.Visible == true)
                dataGridQuaTrinhTangCap.Visible = false;

            if (dataGridView1.Visible == true)
                dataGridView1.Visible = false;
            if(kiemTraNutVuaBam==4)
            {
                kiemTraNutVuaBam = 4;
                btnTangCapDoVuotTroi.Visible = true;
                btntaikhoannguoidung.Visible = true;
                btnQuaTrinhThangCap.Visible = true;
                btnBXHToanCuc.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                dataGridView2.Visible = false;
                btnXem.Visible = false;
                kiemTraNutVuaBam = 0;
            }
            if (dataGridNguoiDungKhongLenCap.Visible == true)
                dataGridNguoiDungKhongLenCap.Visible = false;
        }
        int kiemTraNutVuaBam=0;
        private void frmQuanlinguoidung_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            btnTrove.Visible = false;
            btnTrove.Dock = DockStyle.Bottom;
            conn = new SqlConnection(connstr);
            #region Tài khoản người dùng
            lstV.Visible = false;
            //ListView lstV = new ListView();
            //lstV.Location = new Point(1, 1);
            lstV.Dock = DockStyle.Fill;
            try
            {
                conn.Open();
                commstr = "select UIID,UIAccount from UserInfo";
                dtb = new DataTable();
                dad = new SqlDataAdapter(commstr, conn);
                int total = dad.Fill(dtb);
                conn.Close();
                //conn.Dispose();
                for (int i = 0; i < total; i++)
                {
                    ListViewItem item = new ListViewItem(Convert.ToInt32(dtb.Rows[i][0]).ToString());
                    item.SubItems.Add((string)dtb.Rows[i][1]);
                    lstV.Items.Add(item);

                }
                //Button btnTrove = new Button();
                //btnTrove.Location = new Point(5, 5);
                //btnTrove.Size = new Size(15, 37);
                //btnTrove.Font = new Font("Consolas", 12, FontStyle.Bold);
                //btnTrove.Dock = DockStyle.Bottom;
                //btnTrove.Text = "Back";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
            #region Quá trình tăng cấp
            dataGridQuaTrinhTangCap.Visible = false;
            try
            {
                dataGridQuaTrinhTangCap.Dock = DockStyle.Fill;
                dataGridQuaTrinhTangCap.Visible = false;
                conn.Open();
                commstr = "select * from SoNGayOCapdohientai order by SoNgay desc";
                dad = new SqlDataAdapter(commstr, conn);
                DataTable dtb1 = new DataTable();
                dad.Fill(dtb1);
                dataGridQuaTrinhTangCap.DataSource = dtb1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
             #region Bảng xếp hạng toàn cục
            commstr = "select * from TongPhanTramSoTuDaHocfunction()";
            try
            {
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.Visible = false;
                conn.Open();
                dad = new SqlDataAdapter(commstr, conn);
                DataTable dtb2 = new DataTable();
                dad.Fill(dtb2);
                dataGridView1.DataSource = dtb2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
            #region Tăng cấp nhanh
            dataGridView2.Location = new Point(0, 92);
            dataGridView2.Size = new Size(719, 421);
            dataGridView2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            btnXem.Visible = false;


            #endregion
            #region Nguoidw dùng không lên cấp
            dataGridNguoiDungKhongLenCap.Dock = DockStyle.Fill;
            commstr = "select * from NguoiDungKhongLenCap order by DateStart asc ";
            try
            {
                conn.Open();
                DataTable dtbNguoiDungKhongLenCap = new DataTable();
                dad = new SqlDataAdapter(commstr, conn);
                dad.Fill(dtbNguoiDungKhongLenCap);
                dataGridNguoiDungKhongLenCap.DataSource = dtbNguoiDungKhongLenCap;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion                          
            conn.Dispose();
        }

        private void btnQuaTrinhThangCap_Click(object sender, EventArgs e)
        {
            dataGridQuaTrinhTangCap.Visible = true;
            btnTrove.Visible = true;
            
        }

        private void btnBXHToanCuc_Click(object sender, EventArgs e)
        {
            btnTrove.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.Dock = DockStyle.Fill;

        }

        private void btnTangCapDoVuotTroi_Click(object sender, EventArgs e)
        {
            kiemTraNutVuaBam = 4;
            btnTangCapDoVuotTroi.Visible = false;
            btntaikhoannguoidung.Visible = false;
            btnQuaTrinhThangCap.Visible = false;
            btnBXHToanCuc.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            btnXem.Visible = true;

            btnTrove.Visible = true;
            dataGridView2.Visible = true;

        }

        private void Xem_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            if(textBox1.Text!="")
            {
                int sothang;
                if (int.TryParse(textBox1.Text, out sothang))
                {
                    conn = new SqlConnection(connstr);
                    conn.Open();
                    commstr = "select * from tang2leveltrolentrongvongythangganday(" + sothang + ");";
                    DataTable dtb3 = new DataTable();
                    dad = new SqlDataAdapter(commstr, conn);
                    dad.Fill(dtb3);
                    dataGridView2.DataSource = dtb3;
                    conn.Close();
                    conn.Dispose();
                }
                else MessageBox.Show("Bạn nhập sai số tháng!");
            }
            else
            {
                conn = new SqlConnection(connstr);
                conn.Open();
                commstr = " select *from Tang2LevelTroLenNhanh_chuanxac";
                DataTable dtb3 = new DataTable();
                dad = new SqlDataAdapter(commstr, conn);
                dad.Fill(dtb3);
                dataGridView2.DataSource = dtb3;
                conn.Close();
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnTrove.Visible = true;
            dataGridNguoiDungKhongLenCap.Visible = true;
        }
    }
}
