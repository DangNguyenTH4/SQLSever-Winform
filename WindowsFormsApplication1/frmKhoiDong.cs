using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class frmKhoiDong : Form
    {
        public frmKhoiDong()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmKhoiDong_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (11 < (progressBar1.Value) % 20 && (progressBar1.Value % 20) < 19)
            {
                lbloadding.Visible = false;
            }
            else
            {
                lbloadding.Visible = true;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                //Sự thay thế
                this.Hide();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
