using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Exercise3
{
    internal class Program
    {
        int noStudent;
        int noSubject;
        int id;

        public static double[,] marks;
        public static double total = 0;
        // Setter Getter
        public void setNoStudent(int noStudent)
        {
            this.noStudent = noStudent;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getNoStudent()
        {
            return this.noStudent;
        }

        public void setNoSubject(int noSubject)
        {
            this.noSubject = noSubject;
        }

        public int getNoSubject()
        {
            return this.noSubject;
        }

        public static String gradeCheck(double grade)
        {
            if (80 <= grade && grade <= 100)
                return "A";
            else if (70 <= grade && grade <= 79)
                return "B";
            else if (60 <= grade && grade <= 69)
                return "C";
            else if (50 <= grade && grade <= 59)
                return "D";
            else if (40 <= grade && grade <= 49)
                return "E";
            return "F";
        }

        static void Main(string[] args)
        {
            Program ex2 = new Program();

            int noStudent;
            Console.WriteLine("SIMPLE GRADING SYSTEM");
            Console.Write("Enter no. of students: ");
            noStudent = Convert.ToInt32(Console.ReadLine());
            ex2.setNoStudent(noStudent);

            int noSubject;
            Console.Write("Enter no. of subjects: ");
            noSubject = Convert.ToInt32(Console.ReadLine());
            ex2.setNoSubject(noSubject);

            marks = new double[noStudent, noSubject];
            for (int i = 0; i < noStudent; i++)
            {
                total = 0;
                Console.Write($"\nEnter Student ID: ");
                ex2.setId(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"Enter marks for #{ex2.getId()}");

                for (int j = 0; j < noSubject; j++)
                {
                    Console.Write($"Enter marks for subject {j}: ");
                    marks[i, j] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Grade: " + gradeCheck(marks[i, j]) + "\n");

                    total += marks[i, j];
                }

                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Avg : {total / noSubject}");

                if (total / noSubject >= 40)
                    Console.WriteLine("PROCEED TO THE NEXT SEMESTER");
                else
                    Console.WriteLine("FAILURE");
            }

            Console.ReadKey();
        }
    }
}
