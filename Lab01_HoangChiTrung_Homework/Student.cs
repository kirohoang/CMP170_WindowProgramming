using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Homework
{
    internal class Student : Person
    {
        private string department;
        private double average;

        public Student()
        {
        }

        public Student(string department, double average)
        {
            this.department = department;
            this.average = average;
        }

        public string Department { get => department; set => department = value; }
        public double Average { get => average; set => average = value; }
    }
}
