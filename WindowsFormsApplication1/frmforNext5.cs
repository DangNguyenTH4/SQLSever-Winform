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
    public partial class frmforNext5 : Form
    {
        public frmforNext5()
        {
            InitializeComponent();
        }

        private void frmforNext5_Load(object sender, EventArgs e)
        {

        }
        internal void loadCacThuVao(int mottrong4vitridung,string tudung,byte[] anhdung,byte[] anhsai1, byte[] anhsai2, byte[] anhsai3)
        {
            lbword.Text = tudung;
            if(mottrong4vitridung==1)
            {
                picA.Image = MyConvert2.ConvertBinaryToImage(anhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(anhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(anhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(anhsai3);

            }
            if (mottrong4vitridung == 2)
            {
                picB.Image = MyConvert2.ConvertBinaryToImage(anhdung);
                picA.Image = MyConvert2.ConvertBinaryToImage(anhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(anhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(anhsai3);

            }
            if (mottrong4vitridung == 3)
            {
                picC.Image = MyConvert2.ConvertBinaryToImage(anhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(anhsai1);
                picA.Image = MyConvert2.ConvertBinaryToImage(anhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(anhsai3);

            }
            if (mottrong4vitridung == 4)
            {
                picD.Image = MyConvert2.ConvertBinaryToImage(anhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(anhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(anhsai2);
                picA.Image = MyConvert2.ConvertBinaryToImage(anhsai3);

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
        #region khi click vào ảnh cũng là chọn đáp án
        private void picA_Click(object sender, EventArgs e)
        {
            rdbA.Checked = true;
            WhenClickThePictureA();
        }
        private void picB_Click(object sender, EventArgs e)
        {
            rdbB.Checked = true;
            WhenClickThePictureB();


        }
        private void picC_Click(object sender, EventArgs e)
        {
            rdbC.Checked = true;
            WhenClickThePictueC();
        }
        private void picD_Click(object sender, EventArgs e)
        {
            rdbD.Checked = true;
            WhenClickThePictureD();
        }
        #endregion
        #region Click ảnh nảo thì ảnh đó => dạng Fixed3d
        private void WhenClickThePictureA()
        {
            {
                picA.BorderStyle = BorderStyle.Fixed3D;
                picB.BorderStyle = BorderStyle.None;
                picC.BorderStyle = BorderStyle.None;
                picD.BorderStyle = BorderStyle.None;
            }
        }
        private void WhenClickThePictureB()
        {
            {
                picB.BorderStyle = BorderStyle.Fixed3D;
                picA.BorderStyle = BorderStyle.None;
                picC.BorderStyle = BorderStyle.None;
                picD.BorderStyle = BorderStyle.None;
            }
        }
        private void WhenClickThePictueC()
        {
            picC.BorderStyle = BorderStyle.Fixed3D;
            picB.BorderStyle = BorderStyle.None;
            picA.BorderStyle = BorderStyle.None;
            picD.BorderStyle = BorderStyle.None;
        }
        private void WhenClickThePictureD()
        {
            picD.BorderStyle = BorderStyle.Fixed3D;
            picB.BorderStyle = BorderStyle.None;
            picC.BorderStyle = BorderStyle.None;
            picA.BorderStyle = BorderStyle.None;
        }
        #endregion


    }
}
