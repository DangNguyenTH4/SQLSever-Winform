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
    public partial class frmForAdmin : Form
    {
        string Account,Passwd;
        public frmForAdmin()
        {
            InitializeComponent();
        }
        public frmForAdmin(string acc,string psw):this()
        {
            this.Account = acc;
            this.Passwd = psw;
        }
        frmQuanLiCauHoi quanlicauhoi;
        frmQuanlinguoidung quanlind;
        frmThemQA themQA;
        SqlConnection conn;
        

        private string LopKetNoi()
        {
            string chuoiKetnoi = @"Server=SMC-PC\SQLEXPRESS;Database=ProjectBig_SQL;"
                                    + "Integrated Security=true;"
                                    + "uid=" +Account + ";"
                                    + "password=" + Passwd;
            return chuoiKetnoi;
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Arial", 9);

            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);

            e.Graphics.DrawString("X", drawFont, Brushes.Red, e.Bounds.Right - 12, e.Bounds.Top + 4);

            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left + 1, e.Bounds.Top + 4);

            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)

            {

                Rectangle r = tabControl1.GetTabRect(i);

                //Getting the position of the “x” mark.

                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);

                if (closeButton.Contains(e.Location))

                {

                    if (MessageBox.Show("Would you like to Close this Tab ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {

                        this.tabControl1.TabPages.RemoveAt(i);

                        break;

                    }

                }

            }
        }

        static int KiemTraTonTai(TabControl TabControlName, string TabName)
        {

            int temp = -1;

            for (int i = 0; i < TabControlName.TabPages.Count; i++)

            {

                if (TabControlName.TabPages[i].Text == TabName)

                {

                    temp = i;

                    break;

                }

            }

            return temp;

        }

        public void TabCreating(TabControl TabControl, string Text, Form Form)
        {

            int Index = KiemTraTonTai(TabControl, Text);

            if (Index >= 0)

            {

                TabControl.SelectedTab = TabControl.TabPages[Index];

                TabControl.SelectedTab.Text = Text;



            }

            else

            {

                TabPage TabPage = new TabPage { Text = Text };

                TabControl.TabPages.Add(TabPage);

                TabControl.SelectedTab = TabPage;



                Form.TopLevel = false;

                Form.Parent = TabPage;

                //  Form.MdiParent = this;

                Form.Show();

                Form.Dock = DockStyle.Fill;

            }

        }

        private void btnhotro_Click(object sender, EventArgs e)
        {

            //frmhotrosuco dk1 = new frmhotrosuco();

            //TabCreating(tabControl1, “Hổ trợ kỷ thuật”, dk1);
            Thi1 thi = new Thi1();
            TabCreating(tabControl1, "Thi 1", thi);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thi1 thi = new Thi1(3,"nhicute");
            TabCreating(tabControl1, "Thi 1", thi);

        }

        private void btnQuanLiCauhoi_Click(object sender, EventArgs e)
        {
            string commstr = "select count(*) from QuestionAnswer";
            conn = new SqlConnection(LopKetNoi());
            conn.Open();
            SqlCommand comm = new SqlCommand(commstr, conn);
            if (comm.ExecuteNonQuery() > 0)
            {
                quanlicauhoi = new frmQuanLiCauHoi();
                TabCreating(tabControl1, "Các câu hỏi hiện có", quanlicauhoi);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền này.");
                btnQuanLiCauhoi.Enabled = false;
            }
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            quanlind = new frmQuanlinguoidung();
            TabCreating(tabControl1, "Quản lí người dùng", quanlind);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            quanlind.btnTrove.PerformClick();
        }

        private void btnThemQA_Click(object sender, EventArgs e)
        {
            themQA = new frmThemQA();
            TabCreating(tabControl1, "Thêm câu hỏi", themQA);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmForAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
