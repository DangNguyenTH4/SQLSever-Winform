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
    public partial class frmDoThi2 : Form
    {
        public frmDoThi2()
        {
            InitializeComponent();
        }
        string connstr = @"Data Source = SMC-PC\SQLEXPRESS; Initial Catalog = ProjectBig_SQL; Integrated Security =true;";
        string commstr;
        SqlCommand comm;
        SqlConnection conn;
        SqlDataReader dtread;

        private void frmDoThi2_Load(object sender, EventArgs e)
        {
            commstr = "Select * from ThoiGianTangKeTuCap1(" + Convert.ToInt32(lbUIID.Text) + ");";
            conn = new SqlConnection(connstr);
            conn.Open();
            comm = new SqlCommand(commstr, conn);
            dtread = comm.ExecuteReader();
            while (dtread.Read())
            {
                chart1.Series["Số ngày"].Points.AddXY(dtread.GetInt32(0), dtread.GetInt32(1));
            }
            conn.Close();
            conn.Dispose();
            comm.Dispose();
        }
    }
}
