using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace UngDungHocTiengAnh
{
     public static class MyConvert
    {
        //Chuyển bit->Ảnh
        public static Image ConvertBinaryToImage(byte[] bye)
        {
            MemoryStream ms = new MemoryStream(bye);
            return Image.FromStream(ms);
        }
        //chuyển ảnh-> bit
        public static byte[] ConvertImageToBinary(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        //chuyển ảnh->bit
        public static byte[] ConvertImageToBinary(string filename)
        {
            byte[] bye = null;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            bye = new byte[fs.Length];
            fs.Read(bye, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return bye;

        }
        //chuyển âm->bit
        public static byte[] ConvertMediaToBinaryByFileName(string filename)
        {
            byte[] data = null;
            FileInfo fi = new FileInfo(filename);
            long number = fi.Length;
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)number);
            fs.Close();
            //fs.Dispose();
            return data;
        }
        //chuyển bit->âm
        public static string ConvertBinaryToMediaByFileName(SourceOfQuention Cauhoi,string folder)
        {
            string fileMedia = folder + @"\" + Cauhoi.IDQA + Cauhoi.QAEngWord;
            if(!File.Exists(fileMedia))
            {
                FileStream fs = new FileStream(fileMedia, FileMode.Create);
                for(long i=0;i<fs.Length;i++)
                {
                    fs.WriteByte(Cauhoi.QASound[i]);
                }
                fs.Close();
                fs.Dispose();
            }
            return fileMedia;


        }

    }
}
