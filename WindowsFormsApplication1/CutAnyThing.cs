using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static public class CutOrSplitOrJoinOrFormat
    {
        static public string CutTheExtensions(string safefilename)
        {
            string tenanh = "";
            if (safefilename.Contains("jpg")
                || safefilename.Contains("png")
                || safefilename.Contains("bmp")
                || safefilename.Contains("gif")
                //|| safefilename.Contains("mp3") 
                || safefilename.Contains("mp3")
                || safefilename.Contains("mov"))
            {
                tenanh = safefilename.Substring(0, safefilename.Length - 4);
            }
            if (safefilename.Contains("jpeg")
                || safefilename.Contains("tiff"))
            {
                tenanh = safefilename.Substring(0, safefilename.Length - 5);
            }

            return tenanh;
        }
        //Sẽ xóa bỏ các kí tự khoảng cách thừa ra
        public static void DingDangLaiChuoi_KhongTraVe(ref string a)
        {
            a = a.ToLower();
            string[] b = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            a = string.Join(" ", b);
        }
        public static string DinhDangLaiChuoi_CoTraVeChuoi(string a)
        {

            string[] b = a.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", b);
        }
    }
}

