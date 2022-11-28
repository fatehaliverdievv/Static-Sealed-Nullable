using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticandsealedandnullabletask.Models
{
    internal class Student
    {
        static public int Count;
        int _id;
        string _fullname;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value >0 )
                { 
                    _id = Count;
                    Count++;
                }
            }
        }
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                {
                    value = value.Trim();
                    _fullname = value;

                }
            }
        }
        static Student()
        {
            Count++;
        }
        public Student(string fullname)
        {
            Id++;
            Fullname = fullname;
        }

        public static  bool CheckFullname(string fullnamE)
        {
            fullnamE = fullnamE.Trim();
            string[] fullnameArray = fullnamE.Split(' ');
            (bool name, bool surname) answer=(false, false);
            if (fullnameArray.Length < 3 && fullnameArray.Length >= 1 && Letter(fullnamE) && Digit(fullnamE) == false)
            {
                for (int i = 0; i < fullnameArray.Length; i++)
                {
                    if (char.IsUpper(fullnameArray[i][0]))
                    {
                        if (i == 0)
                        {
                            answer.name = true;
                        }
                        if (i == 1)
                        {
                            answer.surname = true;
                        }

                    }
                }
            }
            //ad soyaddan elave deyer de goture bilir
            //if (fullnameArray.Length >= 1 && Letter(fullnamE) && Digit(fullnamE)==false)
            //{
            //    for (int i = 0; i < fullnameArray.Length; i++)
            //    {
            //        if (char.IsUpper(fullnameArray[i][0]))
            //        {
            //            if (i == 0)
            //            {
            //                answer.name = true;
            //            }
            //            if (i == 1)
            //            {
            //                answer.surname=true;
            //            }
            //        }
            //    }
            //}
            if (answer.name==true && answer.surname==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Letter(string fullname)
        {
            bool answerr = false;
            fullname = fullname.Trim();
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsLetter(fullname[i]))
                {
                    answerr = true; 
                }
            }
            return answerr;
        }
        public static bool Digit(string fullname)
        {
            bool answerr = false;
            fullname = fullname.Trim();
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsDigit(fullname[i]))
                {
                    answerr = true;
                }
            }
            return answerr;
        }

    }
}