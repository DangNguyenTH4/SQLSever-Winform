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
    public partial class frmforNext1 : Form
    {
        public frmforNext1()
        {
            InitializeComponent();
        }

        private void frmforNext1_Load(object sender, EventArgs e)
        {
          
        }

        
        //Load câu hỏi vào 
        internal void loadCacThuVao(int motTrong4vitridung,byte[] hinhanhdung, byte[] hinhanhsai1, byte[] hinhanhsai2, byte[] hinhanhsai3, string QACode, byte[] amthanh)
        {
            if(motTrong4vitridung==1)
            {
                picA.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai3);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (motTrong4vitridung == 2)
            {
                picB.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
                picA.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai3);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (motTrong4vitridung == 3)
            {
                picC.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai1);
                picA.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai2);
                picD.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai3);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
            if (motTrong4vitridung == 4)
            {
                picD.Image = MyConvert2.ConvertBinaryToImage(hinhanhdung);
                picB.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai1);
                picC.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai2);
                picA.Image = MyConvert2.ConvertBinaryToImage(hinhanhsai3);
                axWindowsMediaPlayer1.URL = MyConvert2.ConvertBinaryToMediaByFileName1(QACode, amthanh);
            }
        }
        internal bool kiemtraXemChonDungKhong(int vitridapandung)
        {
            if (rdbA.Checked == true && vitridapandung == 1)
                return true;
            else if (rdbB.Checked == true&&vitridapandung==2)
                return true;
            else if (rdbC.Checked == true&&vitridapandung==3)
                return true;
            else if (rdbD.Checked == true && vitridapandung == 4)
                return true;
            else return false;

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
        //Khi bấm next sẽ không lưu lại vị trí câu đã chọn của câu trước
        internal void bochontatca()
        {
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }

        internal void frmforNext1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //internal bool nhanenter = false;
        private void  frmforNext1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
           // {
            //    nhanenter = true;
           // }

            //else //return false;
        }
    }
}
