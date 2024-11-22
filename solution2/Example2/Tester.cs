using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            StudentList lstStudent = new StudentList();
            Console.Write("Enter number of student: ");
            lstStudent.number = int.Parse(Console.ReadLine());

            List<Student> lst = lstStudent.Input_lstStudent();
            lstStudent.output_lstStuden(lst);
            lstStudent.output_it_lstStudent(lst);
            lstStudent.output_arrange_lstStudent(lst);

            Console.ReadLine();
        }
    }
}
