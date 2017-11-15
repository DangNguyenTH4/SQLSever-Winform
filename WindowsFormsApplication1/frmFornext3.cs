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
    public partial class frmFornext3 : Form
    {
        public frmFornext3()
        {
            InitializeComponent();
        }

        private void frmFornext3_Load(object sender, EventArgs e)
        {

        }
        internal void loadCacThuVao(int mottrong4vitridung,byte[] hinhanhdung, byte[] amthanhdung,byte[] amthanhsai1, byte[] amthanhsai2, byte[] amthanhsai3,string QACodedung,string QACodeSai1, string QACodeSai2, string QACodeSai3)
        {
            if(mottrong4vitridung==1)
            {
                axA.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodedung, amthanhdung);
                axB.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai1, amthanhsai1);
                axC.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai2, amthanhsai2);
                axD.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai3, amthanhsai3);
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
            }
            if (mottrong4vitridung == 2)
            {
                axB.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodedung, amthanhdung);
                axA.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai1, amthanhsai1);
                axC.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai2, amthanhsai2);
                axD.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai3, amthanhsai3);
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
            }
            if (mottrong4vitridung == 3)
            {
                axC.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodedung, amthanhdung);
                axB.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai1, amthanhsai1);
                axA.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai2, amthanhsai2);
                axD.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai3, amthanhsai3);
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
            }
            if (mottrong4vitridung == 4)
            {
                axD.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodedung, amthanhdung);
                axB.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai1, amthanhsai1);
                axC.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai2, amthanhsai2);
                axA.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACodeSai3, amthanhsai3);
                pictureBox1.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
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
        #region Click vào âm thanh cũng là chọn đáp án
        private void axD_Enter(object sender, EventArgs e)
        {
            rdbD.Checked = true;

        }

        private void axC_Enter(object sender, EventArgs e)
        {
            rdbC.Checked = true;

        }

        private void axB_Enter(object sender, EventArgs e)
        {
            rdbB.Checked = true;

        }

        private void axA_Enter(object sender, EventArgs e)
        {
            rdbA.Checked = true;

        }
        #endregion
    }
}
