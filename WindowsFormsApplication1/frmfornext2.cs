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
    public partial class frmfornext2 : Form
    {
        public frmfornext2()
        {
            InitializeComponent();
        }

        private void frmfornext2_Load(object sender, EventArgs e)
        {

        }
        internal void loadCacThuVao(int mottrong4Vitridung,string dapandung,string dapansai1,string dapansai2,string dapansai3,string QACode,byte[] amthanh)
        {
            if(mottrong4Vitridung==1)
            {
                lbA.Text = dapandung;
                lbB.Text = dapansai1;
                lbC.Text = dapansai2;
                lbD.Text = dapansai3;
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (mottrong4Vitridung == 2)
            {
                lbB.Text = dapandung;
                lbA.Text = dapansai1;
                lbC.Text = dapansai2;
                lbD.Text = dapansai3;
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (mottrong4Vitridung == 3)
            {
                lbC.Text = dapandung;
                lbB.Text = dapansai1;
                lbA.Text = dapansai2;
                lbD.Text = dapansai3;
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (mottrong4Vitridung == 4)
            {
                lbD.Text = dapandung;
                lbB.Text = dapansai1;
                lbC.Text = dapansai2;
                lbA.Text = dapansai3;
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
        #region Click vào từ cũng là chọn đáp án
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
