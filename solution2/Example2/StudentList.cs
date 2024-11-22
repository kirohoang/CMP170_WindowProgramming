using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class StudentList
    {
        public int number;
        List<Student> lstStudents = new List<Student>();

        public int SL { get => number; set => number = value; }

        public List<Student> Input_lstStudent()
        {
            Console.WriteLine("\nInput Student List");
            for (int i = 0; i < number; i++)
            {
                Student temp = new Student();
                temp.input();
                lstStudents.Add(temp);
            }
            return lstStudents;
        }

        public void output_lstStuden(List<Student> lstStu)
        {
            Console.WriteLine("\nOutput Student List");
            foreach (Student sv in lstStu)
            {
                sv.Output();
            }
        }

        public void output_it_lstStudent(List<Student> lstStu)
        {
            List<Student> lstIT = lstStu.Where(p => p.Faculty == "IT").ToList();
            Console.WriteLine("\nOutput IT Student List");
            foreach(Student sv in lstIT)
            {
                sv.Output();
            }
        }

        public void output_arrange_lstStudent(List<Student> lstStu)
        {
            List<Student> lst_arrange = lstStu.OrderBy(p =>  p.Avg).ToList();
            Console.WriteLine("\nList sorted in increase by avg score");
            foreach (Student sv in lst_arrange)
            {
                sv.Output();
            }
        }
    }
}
