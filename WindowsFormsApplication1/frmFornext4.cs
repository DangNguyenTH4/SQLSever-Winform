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
    public partial class frmFornext4 : Form
    {
        public frmFornext4()
        {
            InitializeComponent();
        }

        private void frmFornext4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        internal void loadCacThuVao(int mottrong4vitridung,string phienamdung,string phienamsai1,string phienamsai2,string phienamsai3,string QACode,byte[] hinhanh,byte[] amthanh)
        {
            if(mottrong4vitridung==1)
            {
                lbA.Text = phienamdung;
                lbB.Text = phienamsai1;
                lbC.Text = phienamsai2;
                lbD.Text = phienamsai3;
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanh);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);

            }
            if (mottrong4vitridung == 2)
            {
                lbB.Text = phienamdung;
                lbA.Text = phienamsai1;
                lbC.Text = phienamsai2;
                lbD.Text = phienamsai3;
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanh);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);

            }
            if (mottrong4vitridung == 3)
            {
                lbC.Text = phienamdung;
                lbB.Text = phienamsai1;
                lbA.Text = phienamsai2;
                lbD.Text = phienamsai3;
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanh);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);

            }
            if (mottrong4vitridung == 4)
            {
                lbD.Text = phienamdung;
                lbB.Text = phienamsai1;
                lbC.Text = phienamsai2;
                lbA.Text = phienamsai3;
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanh);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);

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
