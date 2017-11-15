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
    public partial class frmQuanLiCauHoi : Form
    {
        public frmQuanLiCauHoi()
        {
            InitializeComponent();
        }
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS;Initial Catalog = ProjectBig_SQL;Integrated Security = true;";
        string commstr;
        SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter dad;
        DataTable dtb;
        DataSet dts;
        DataColumn dtcl;
        DataRow dtrow;
        private void frmQuanLiCauHoi_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            conn = new SqlConnection(connstr);
            conn.Open();
            commstr = "select IDQA,QACode,QAEngWord,QAVietWord,QAPronunciation,TypeOfWord from QuestionAnswer ";

            dad = new SqlDataAdapter(commstr, conn);
            dtb = new DataTable();
            int x = dad.Fill(dtb);
            if (x > 0)
            {
                dataGridView1.DataSource = dtb;
            }
            else
                MessageBox.Show("Không kết nối được với CSDL");
            conn.Close();
            conn.Dispose();
        }
    }
}
