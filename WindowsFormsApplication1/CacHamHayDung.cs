using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class CacHamHayDung
    {
        public static void DatHinhAnhVaoViTriDung(int vitridung,byte[] incre0, byte[] incre1, byte[] incre2, byte[] incre3)
        {
           
        }


        //Thủ tục có tham số vào là Tổng số câu hỏi trong 1 chủ đề, vị trí của đáp án đúng(Vitrikhongduoclay)
        //Trả về mảng gồm 4 số là 4 vị trí sẽ lấy để là 1 câu hỏi
        //Trong đó xxx[0] là câu đáp án đúng, (vitrikhongduoclay<=>)
        //vitrikhongduoclay<=> xxx[0]<=> takenQuestion[n] voi n sothutucua cau
        // xxx<=> takeIncorrect[]
        public static int[] RandomViTriLayCua3CauSai(int TongSoCauHienCo, int vitriKhongduocLay)
        {
            int[] xxx = new int[4];
            xxx[0] = vitriKhongduocLay;
            Random ran = new Random();
            for (int i=0;i<4;i++)
            {
                int x = 0;
                bool check = false;
                if(i!=0)
                {
                    while(check==false)
                    {
                        x = ran.Next(0, TongSoCauHienCo);
                        for(int j=0;j<i;j++)
                        {
                            if (x == xxx[j])
                                break;
                            if (j == i - 1 && x != xxx[j])
                                check = true;
                        }
                    }
                }
                xxx[i] = x;
            }
            return xxx;
        }
        //Tu cau 1-30
        public static  void RamdomCho30CauSapToi(ref int[] takenQuestions, int tongsocauhienco)

        {
            Random ran = new Random();
            for (int i = 1; i < 30; i++)
            {
                int x = 0;
                bool check = false;
                while (check == false)
                {
                    x = ran.Next(0, tongsocauhienco);
                    for (int j = 0; j < i; j++)
                    {
                        if (x == takenQuestions[j])
                            break;
                        if (j == i - 1 && x != takenQuestions[j])
                            check = true;
                    }
                }
                takenQuestions[i] = x;
            }
        }
        //public static void LoadChuDeDuocHocVaoCombobox(int UIID, )
    }
}
