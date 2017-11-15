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

    public partial class frmDothi : Form
    {
        string account;
        int uiid;
        public frmDothi()
        {
            InitializeComponent();
        }
        public frmDothi(int uiid,string account):this()
        {
            this.uiid = uiid;
            this.account = account;
        }
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS; Initial Catalog = ProjectBig_SQL; Integrated Security =true;";
        string commstr;
        SqlCommand comm;
        SqlConnection conn;
        SqlDataReader dtread;

        private void frmDothi_Load(object sender, EventArgs e)
        {
            commstr = "Select * from ThoiGianTangKeTuCap1(" +uiid + ");";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            dtread = comm.ExecuteReader();
            while(dtread.Read())
            {
                chart1.Series["Mức độ tăng cấp"].Points.AddXY(dtread.GetInt32(1), dtread.GetInt32(0));
            }
            conn.Close();
            conn.Dispose();
            comm.Dispose();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
