using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MyRandom
    {
        //Một vấn đề nhạy cảm: Khi mình dùng quá nhiều đối tượng random nó sẽ sao sao ý, nên phải ntn 
        static Random ran = new Random();
        public static int[] RandomViTriLayCauHoi(int soCauCo,int soluongMuonrandom)
        {
            //Random ran  = new Random();

            int[] mangvitri = new int[soluongMuonrandom];
            mangvitri[0] = ran.Next(soCauCo);
            for (int i = 1 ;i<soluongMuonrandom;i++)
            {
                int x = 0;
                bool check = false;
                while (check == false)
                {
                    

                    x = ran.Next(soCauCo);
                    for (int j = 0; j < i; j++)
                    {
                        if (x == mangvitri[j])
                            break;
                        if (j == i - 1 && x != mangvitri[j])
                            check = true;
                    }
                }
                mangvitri[i] = x;
            }
            return mangvitri;
        }
        public static int[] random3vitriconlai(int vitridapandung,int soCauCo)
        {
            int x = 0;
            int[] xxx = new int[4];
            xxx[0] = vitridapandung;
            for(int i=1;i<4;i++)
            {
                //Random ran = new Random();
                bool check = false;
                while(check==false)
                {
                 x= ran.Next(soCauCo);

                    for (int j=0;j<i;j++)
                    {
                        if (x == xxx[j])
                            break;
                        if (j == i - 1 && x != xxx[j])
                            check = true;
                    }
                }
                xxx[i] = x;
            }
            return xxx;
        }
        public static int random1trong4vitridung()
        {
            //Random ran = new Random();
            return ran.Next(4) + 1;
        }
        //public static int randomLoaiform()
        
    }
}
