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
    public partial class frmforNext6 : Form
    {
        public frmforNext6()
        {
            InitializeComponent();
        }

        private void frmforNext6_Load(object sender, EventArgs e)
        {

        }
        internal void loadCacThuVao(int mottrong4vitridung,byte[] hinhanhdung,string tudung,string tusai1,string tusai2,string tusai3)
        {
            pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
            if(mottrong4vitridung==1)
            {
                lbA.Text = tudung;
                lbB.Text = tusai1;
                lbC.Text = tusai2;
                lbD.Text = tusai3;
            }
            if (mottrong4vitridung == 2)
            {
                lbB.Text = tudung;
                lbA.Text = tusai1;
                lbC.Text = tusai2;
                lbD.Text = tusai3;
            }
            if (mottrong4vitridung == 3)
            {
                lbC.Text = tudung;
                lbB.Text = tusai1;
                lbA.Text = tusai2;
                lbD.Text = tusai3;
            }
            if (mottrong4vitridung == 4)
            {
                lbD.Text = tudung;
                lbB.Text = tusai1;
                lbC.Text = tusai2;
                lbA.Text = tusai3;
            }
        }
        internal bool kiemtraXemChonDungKhong(int vitridapandung)
        {
            if (rdbA.Checked == true && vitridapandung == 1)
                return true;
            else if (rdbB.Checked == true && vitridapandung == 2)
                return true;
            else if (rdbC.Checked == true && vitridapandung == 3)
                return true;
            else if (rdbD.Checked == true && vitridapandung == 4)
                return true;
            else return false;

        }
        internal void bochontatca()
        {
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }
        #region Click vào chữ cũng là chọn đáp án
        private void lbA_Click(object sender, EventArgs e)
        {
            rdbA.Checked = true;
        }

        private void lbB_Click(object sender, EventArgs e)
        {
            rdbB.Checked = true;
        }

        private void lbC_Click(object sender, EventArgs e)
        {
            rdbC.Checked = true;
        }

        private void lbD_Click(object sender, EventArgs e)
        {
            rdbD.Checked = true;
        }
        #endregion
    }
}
