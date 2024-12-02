using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Homework
{
    internal class Teacher : Person
    {
        private string address;

        public Teacher()
        {
        }

        public Teacher(string address)
        {
            this.address = address;
        }

        public string Address { get => address; set => address = value; }
    }
}
