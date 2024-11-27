using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Exercise4
{
    internal class Student
    {
        private int studentCode;
        private string studentName;
        private string studentDepartment;
        private double studentAvg;

        public int StudentCode { get => studentCode; set => studentCode = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentDepartment { get => studentDepartment; set => studentDepartment = value; }
        public double StudentAvg { get => studentAvg; set => studentAvg = value; }
    }
}
