using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Homework
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        // Student
        static void addStudent()
        {
            Student student = new Student();
            Console.Write("Student Code: ");
            student.Code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            student.FullName = Console.ReadLine();

            Console.Write("Student Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Student Average: ");
            student.Average = Convert.ToDouble(Console.ReadLine());

            students.Add(student);
        }
        static void exportAllStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no data available yet");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Student Code: {student.Code}, Student Name: {student.FullName}, Student Department: {student.Department}, Student Average: {student.Average}");
                }
            }
        }
        static void exportStudentDepartment()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no data available yet");
            }
            else
            {
                foreach (var student in students)
                {
                    if (student.Department.Equals("IT"))
                    {
                        Console.WriteLine($"Student Code: {student.Code}, Student Name: {student.FullName}, Student Department: {student.Department}, Student Average: {student.Average}");
                    }
                }
            }
        }
        static void exportHighestAverageScore()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no data available yet");
            }
            else
            {
                foreach (var student in students)
                {
                    if (student.Average > 9 && student.Department.Equals("IT"))
                    {
                        Console.WriteLine($"Student Code: {student.Code}, Student Name: {student.FullName}, Student Department: {student.Department}, Student Average: {student.Average}");
                    }
                }
            }
        }
        static void exportStudentMenu()
        {
            int choice;
            Console.WriteLine("1. Export All Student \n" +
                                "2. Export By Department\n" +
                                "3. Export By Highest Average Score\n" +
                                "0. Back\n" +
                                "------------------");
            Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    exportAllStudent();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    exportStudentMenu();
                    break;
                case 2:
                    exportStudentDepartment();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    exportStudentMenu();
                    break;
                case 3:
                    exportHighestAverageScore();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    exportStudentMenu();
                    break;
                default:
                    main_menu();
                    break;
            }
        }
        // Teacher
        static void addTeacher()
        {
            Teacher teacher = new Teacher();
            Console.Write("Teacher Code: ");
            teacher.Code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Teacher Name: ");
            teacher.FullName = Console.ReadLine();

            Console.Write("Teacher Address: ");
            teacher.Address = Console.ReadLine();

            teachers.Add(teacher);
        }
        static void exportAllTeacher()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("There is no data available right now");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Student Code: {teacher.Code}, Student Name: {teacher.FullName}, Student Department: {teacher.Address}");
                }
            }
        }
        static void exportTeacherWithAddress()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("There is no data available right now");
            }
            else
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Address.Equals("District 9"))
                    {
                        Console.WriteLine($"Student Code: {teacher.Code}, Student Name: {teacher.FullName}, Student Department: {teacher.Address}");
                    }
                }
            }
        }
        static void exportTeacherMenu()
        {
            int choice;
            Console.WriteLine("1. Export All Teacher \n" +
                                "2. Export By Address\n" +
                                "0. Back\n" +
                                "------------------");
            Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    exportAllTeacher();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    exportTeacherMenu();
                    break;
                case 2:
                    exportTeacherWithAddress();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    exportTeacherMenu();
                    break;
                default:
                    main_menu();
                    break;
            }
        }
        // Main menu
        static void main_menu()
        {
            int choice;
            Console.WriteLine("Management Application");
            Console.WriteLine("1. Add Students");
            Console.WriteLine("2. Add Teachers");
            Console.WriteLine("3. Export Student List");
            Console.WriteLine("4. Export Teacher List");
            Console.WriteLine($"Number Of Students: {students.Count}");
            Console.WriteLine($"Number Of Teachers: {teachers.Count}");
            Console.WriteLine("0. Exit");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    addStudent();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    main_menu();
                    break;
                case 2:
                    addTeacher();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    main_menu();
                    break;
                case 3:
                    exportStudentMenu();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    main_menu();
                    break;
                case 4:
                    exportTeacherMenu();
                    Console.WriteLine("\nPress any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    main_menu();
                    break;
                default:
                    break;
            }
        }
        // Execute main menu in main
        static void Main(string[] args)
        {
            main_menu();
            Console.ReadKey();
        }
    }
}
