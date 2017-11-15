using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHocTiengAnh
{
    public class SourceOfQuention
        {

            //private int idqa;
            //private string qaCode;
            //private int idSubject;
            //private byte[] qaSound;
            //private byte[] qaPicture;
            //private string qaEngWord;
            //private string qaVietWord;
            //private string qaExample_Eng;
            //private string qaExample_Viet;

            public int IDQA { get; set; }
            public string QACode { get; set; }
            public int IDSubject { get; set; }
            public byte[] QASound { get; set; }
            public byte[] QAPicture { get; set; }
            public string QAEngWord { get; set; }
            public string QAVietWord { get; set; }
            public string QAExample_Eng { get; set; }
            public string QAExample_Viet { get; set; }


            public SourceOfQuention()
            {
            }
            public SourceOfQuention(int IDQA1, string QACode1, int IDSubject1,
                                    byte[] QASound1, byte[] QAPicture1, string QAEngWord1,
                                    string QAVietWord1, string QAExample_Eng1, string QAExample_Viet1)
            {
                this.IDQA = IDQA1;
                this.QACode = QACode1;
                this.IDSubject = IDSubject1;
                this.QASound = QASound1;
                this.QAPicture = QAPicture1;
                this.QAEngWord = QAEngWord1;
                this.QAVietWord = QAVietWord1;
                this.QAExample_Eng = QAExample_Eng1;
                this.QAExample_Viet = QAExample_Viet1;
            }
        }
    public class QuestionType1
    {
        public byte[] Picture_Sound { get; set; }
        public string DapAn1 { get; set; }
        public string DapAn2 { get; set; }
        public string DapAn3 { get; set; }
        public string DapAn4 { get; set; }
        public QuestionType1()
        { }
        public QuestionType1(byte[] Picture_Sound, string DapAn1,string DapAn2, string DapAn3, string DapAn4)
        {
            this.Picture_Sound = Picture_Sound;
            this.DapAn1 = DapAn1;
            this.DapAn2 = DapAn2;
            this.DapAn3 = DapAn3;
            this.DapAn4 = DapAn4;
        }
    }
    public class QuestionType2
    {
        public string Word { get; set; }
        byte[] Picture_Sound1 { get; set; }
        byte[] Picture_Sound2 { get; set; }
        byte[] Picture_Sound3 { get; set; }
        byte[] Picture_Sound4 { get; set; }
        public QuestionType2() { }
        public QuestionType2(string Word,byte[] Picture_Sound1, byte[] Picture_Sound2,
                                byte[] Picture_Sound3, byte[] Picture_Sound4)
        {
            this.Word = Word;
            this.Picture_Sound1 = Picture_Sound1;
            this.Picture_Sound2 = Picture_Sound2;
            this.Picture_Sound3 = Picture_Sound3;
            this.Picture_Sound4 = Picture_Sound4;

        }
    }
    public class Subject_
    {
        public int IDSubject { get; set; }
        public int IDLevel_ { get; set; }
        public string SubjectName { get; set; }
        public Subject_() { }
        public Subject_(int IDSubject,int IDLevel_,string SubjectName)
        {
            this.IDSubject = IDSubject;
            this.IDLevel_ = IDLevel_;
            this.SubjectName = SubjectName;
        }

    }        
    public class UserInfo
    {
        public int UIID { get; set; }
        public string UIName { get; set; }
        public DateTime UIBirthday { get; set; }
        public string UIAddress { get; set; }
        public bool UISex { get; set; }
        public string UIPhone { get; set; }
        public string UIMail { get; set; }
        public string UIAccount { get; set; }
        public string UIPasswd { get; set; }
        public UserInfo() { }
        public UserInfo(int ID,string Name,DateTime Birthday, string Address,bool Sex,
                        string Phone,string Mail,string Account,string Pass)
        {
            UIID = ID;
            UIName = Name;
            UIBirthday = Birthday;
            UIAddress = Address;
            UISex = Sex;
            UIPhone = Phone;
            UIMail = Mail;
            UIAccount = Account;
            UIPasswd = Pass;
        }


    }
}

