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
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
        }
        int socauhoi;
        int haha;
        int[] mangvitri;
        string connstr = @"data source = SMC-PC\SQLEXPRESS; database = ProjectBig_SQL; Integrated Security =true;";
        string commstr = "select * from QuestionAnswer";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter dad;
        DataTable dtb;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            haha = 0;
            if(textBox1.Text=="")
            {
                listBox1.Items.Clear();
            }
            else
            {
                listBox1.Items.Clear();
                for(int i=0;i<socauhoi;i++)
                {
                    if(dtb.Rows[i][5].ToString().Contains(textBox1.Text)||textBox1.Text.Contains(dtb.Rows[i][5].ToString()))
                    {
                        listBox1.Items.Add(dtb.Rows[i][5].ToString());
                        mangvitri[haha] = i;
                        haha++;
                    }
                }


            }

        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {
            dtb = new DataTable();
            conn = new SqlConnection(connstr);
            conn.Open();
            dad = new SqlDataAdapter(commstr, conn);
            socauhoi = dad.Fill(dtb);
            conn.Close();
            conn.Dispose();
            dad.Dispose();
            mangvitri = new int[socauhoi];
                
        }
    }
}
