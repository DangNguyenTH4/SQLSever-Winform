using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public static class MyConvert2
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
       // public static byte[] ConvertMediaToBinaryByFileName(string filename)
        //{
        //    byte[] data = null;
        //    FileInfo fi = new FileInfo(filename);
        //    long number = fi.Length;
        //    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);
        //    data = br.ReadBytes((int)number);
        //    fs.Close();
        //    //fs.Dispose();
        //    return data;
        //}
        //chuyển bit->âm
        //public static string ConvertBinaryToMediaByFileName(string QACode, byte[] QASound)
        //{
        //    string fileMedia = @"C:\Myproject" + @"\" + QACode + ".mp3";
        //    if (!File.Exists(fileMedia))
        //    {
        //        FileStream fs = new FileStream(fileMedia, FileMode.Create);
        //        for (long i = 0; i < fs.Length; i++)
        //        {  
        //            fs.WriteByte(QASound[i]);
        //        }
        //        fs.Close();
        //        fs.Dispose();
        //    }
        //    return fileMedia;
        //}
        public static string ConvertBinaryToMediaByFileName1(string QACode, byte[] QASound)

        {
            string fileMedia = @"C:\Myproject" + @"\" + QACode;
            if (!File.Exists(fileMedia))
            {
                Stream wrtingStream = new FileStream(fileMedia, FileMode.Create);
                if(wrtingStream.CanWrite)
                {
                    wrtingStream.Write(QASound, 0, QASound.Length);
                }
                wrtingStream.Close();
                wrtingStream.Dispose();
            }
            return fileMedia;

        }

        public static byte[] ConvertMediaToBinary(string fileName)
        {

            byte[] data = null;
            FileInfo fi = new FileInfo(fileName);
            long number = fi.Length;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)number);  //phải sử dụng ép kiểu như này là vì fi.length là kiể long, còn readbinary(k đọc kiểu long)
            fs.Close();
            fs.Dispose();
            return data;
        }
    }
}
