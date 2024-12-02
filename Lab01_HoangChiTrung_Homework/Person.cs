using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Homework
{
    internal class Person
    {
        private int code;
        private string fullName;

        public Person()
        {

        }

        public Person(int code, string fullName)
        {
            this.code = code;
            this.fullName = fullName;
        }

        public int Code { get => code; set => code = value; }
        public string FullName { get => fullName; set => fullName = value; }
    }
}
