using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment
{
    class Employee
    {

        public string Name;
        private int age;
        private int rezident;
        public string LastWork;
        public string Post;
        public Prinimaet prinimaet;
        public DateTime First;  //когда начал работать
        public DateTime Last; // когда уволился
        public Employee(string name, string lastwork, string post, DateTime first, DateTime last)
        {
            Name = name;
            LastWork = lastwork;
            Post = post;
            First = first;
            Last = last;
        }

        public Employee(string v1, string v2, string v3, (int, int, int) p1, (int, int, int) p2)
        {
        }

        public int Rezident
        {
            get
            {
                return rezident;
            }
            set
            {
                if (value < 183)
                {
                    throw new Non_resident("Не является резидентом РФ");
                }
                else
                {
                    rezident = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<18)
                {
                    throw new Minor("Меньше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
         TimeSpan _expiriense//число лет
        {
            get
            {
                return _expiriense;
            }
            set
            {
                _expiriense = First - Last ;
            }
        }

        public void PrintExpiriense()
        {
            Console.WriteLine("Опыт работы:" +  _expiriense );
        }
        public void PrintWhoPrinimaet()
        {
            Console.WriteLine("На работу его принял: " + prinimaet);
        }
        public void LastWorke()
        {
            Console.WriteLine("Предыдущая работа : ", LastWork);
        }


    }
}
