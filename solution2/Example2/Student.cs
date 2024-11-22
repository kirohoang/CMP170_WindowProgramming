using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Student : Person
    {
        private float averageScore;
        private string faculty;

        // Default constructor
        public Student()
        {
            studentID = fullName = faculty = null;
            averageScore = 0;
        }

        public Student(Student st)
        {
            studentID = st.studentID;
            fullName = st.fullName;
            averageScore = st.averageScore;
            faculty = st.faculty;
        }

        //constructor parameters
        public Student(string id, string name, float avg, string fac)
        {
            studentID = id;
            fullName = name;
            averageScore = avg;
            faculty = fac;
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string Name
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public float Avg
        {
            get => averageScore; set => averageScore = value;
        }
        public string Faculty
        {
            get => faculty; set => faculty = value;
        }

        public void Output()
        {
            Console.WriteLine("ID: {0} Fullname: {1} Faculty: {2} AverageMark: {3}", this.studentID, this.fullName, this.faculty, this.averageScore);
        }

        public void input()
        {
            Console.Write("Enter student ID: ");
            StudentID = Console.ReadLine();
            Console.Write("FullName: ");
            Name = Console.ReadLine();
            Console.Write("Faculty: ");
            Faculty = Console.ReadLine();
            Console.Write("Average Score: ");
            Avg = float.Parse(Console.ReadLine());
        }
    }
}
