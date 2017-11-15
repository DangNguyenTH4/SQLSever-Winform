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
    public partial class frmRatings : Form
    {
        int uiid;
        string account;
        public frmRatings()
        {
            InitializeComponent();
        }
        public frmRatings(int uiid,string account):this()
        {
            this.uiid = uiid;
            this.account = account;
        }
        
        #region Khởi tạo đối tượng kết nối và chuỗi kết nối CSDL
        SqlCommand comm;
        SqlConnection conn;
        string commstr;
        string connstr = @"Data Source=SMC-PC\SQLEXPRESS;Initial Catalog=ProjectBig_Sql;Integrated Security=True";

        SqlDataAdapter dad;
        DataTable dtb;
        DataSet dts;
        #endregion
        private void frmRatings_Load(object sender, EventArgs e)
        {
            commstr = "select * from dbo.thuhangfunc(" + uiid + ");";
            conn = new SqlConnection(connstr);
            conn.Open();
            //comm = new SqlCommand(commstr, conn);
            dad = new SqlDataAdapter(commstr,conn);
            dtb = new DataTable();
            int z= dad.Fill(dtb);
            conn.Close();

            //dataGridView1.DataSource = dtb;
            for(int i=0;i<z;i++)
            {
                ListViewItem item = new ListViewItem(((int)dtb.Rows[i][0]).ToString());
                item.SubItems.Add((string)dtb.Rows[i][1]);
                item.SubItems.Add(((int)dtb.Rows[i][2]).ToString());
                listView2.Items.Add(item);
            }

            commstr = "select * from dbo.thuhanghoctap(" + uiid + ");";
            conn.Open();
            dad = new SqlDataAdapter(commstr, conn);
            //dtb.Clear();
            DataTable dtb1 = new DataTable();
            int x = dad.Fill(dtb1);
            conn.Close();
            //dataGridView2.DataSource = dtb1;
            //listBox1.DataSource = dtb;
            for(int i=0; i<x;i++)
            {
                ListViewItem item = new ListViewItem(((int)dtb1.Rows[i][0]).ToString());
                item.SubItems.Add((string)dtb1.Rows[i][1]);
                item.SubItems.Add((string)dtb1.Rows[i][2]);
                listView1.Items.Add(item);
            }
            
            //dataGridView1.DataBind();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmHoc hoc = new frmHoc(uiid, account);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //if (account == listView1.Items[i].SubItems[1].ToString())
                    
                        //listView1.SelectedItems[i];
                        //listView1.FullRowSelect = true;



             }
                            
        }
    }
}
