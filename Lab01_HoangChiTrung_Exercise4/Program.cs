using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Exercise4
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void addStudent()
        {
            Student student = new Student();
            Console.Write("Enter student code: ");
            student.StudentCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student name: ");
            student.StudentName = Console.ReadLine();

            Console.Write("Enter student department: ");
            student.StudentDepartment = Console.ReadLine();

            Console.Write("Enter student average score: ");
            student.StudentAvg = Convert.ToDouble(Console.ReadLine());

            students.Add(student);
        }

        static void exportAllStudent()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Student code: {item.StudentCode}, " +
                                    $"Student name: {item.StudentName}, " +
                                    $"Student Department: {item.StudentDepartment}, " +
                                    $"Student Average: {item.StudentAvg}");
            }
        }

        static void exportByDepartment()
        {
            foreach (var item in students)
            {
                if (item.StudentDepartment.Equals("IT"))
                {
                    Console.WriteLine($"Student code: {item.StudentCode}, " +
                                    $"Student name: {item.StudentName}, " +
                                    $"Student Department: {item.StudentDepartment}, " +
                                    $"Student Average: {item.StudentAvg}");
                }
            }
        }

        static void exportByGreaterThanFive()
        {
            foreach (var item in students)
            {
                if (item.StudentAvg > 5.0)
                {
                    Console.WriteLine($"Student code: {item.StudentCode}, " +
                                    $"Student name: {item.StudentName}, " +
                                    $"Student Department: {item.StudentDepartment}, " +
                                    $"Student Average: {item.StudentAvg}");
                }
            }
        }

        static void exportByGreaterThanFiveAndIT()
        {
            foreach (var item in students)
            {
                if (item.StudentAvg > 5.0 && item.StudentDepartment.Equals("IT"))
                {
                    Console.WriteLine($"Student code: {item.StudentCode}, " +
                                    $"Student name: {item.StudentName}, " +
                                    $"Student Department: {item.StudentDepartment}, " +
                                    $"Student Average: {item.StudentAvg}");
                }
            }
        }

        static void exportByAscent()
        {
            var sortedStudent = students.OrderBy(s => s.StudentAvg).ToList();
            foreach (var student in sortedStudent)
            {
                Console.WriteLine($"Student code: {student.StudentCode}, " +
                                    $"Student name: {student.StudentName}, " +
                                    $"Student Department: {student.StudentDepartment}, " +
                                    $"Student Average: {student.StudentAvg}");
            }
        }

        static void exportByHighest()
        {
            foreach (var item in students)
            {
                if (item.StudentAvg > 9.0 && item.StudentDepartment.Equals("IT"))
                {
                    Console.WriteLine($"Student code: {item.StudentCode}, " +
                                    $"Student name: {item.StudentName}, " +
                                    $"Student Department: {item.StudentDepartment}, " +
                                    $"Student Average: {item.StudentAvg}");
                }
            }
        }

        static void exportStudentMenu()
        {
            int choice;
            Console.WriteLine("1. Export All");
            Console.WriteLine("2. Export By Department");
            Console.WriteLine("3. Export by average score greater than 5");
            Console.WriteLine("4. Export by average score by increasing");
            Console.WriteLine("5. Export by Average score greater than 5 and IT department");
            Console.WriteLine("6. Export by Highest Average score and IT department");
            Console.WriteLine("0. Back");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    exportAllStudent();
                    Console.WriteLine("\nPress any key to go back!");
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                case 2:
                    exportByDepartment();
                    Console.WriteLine("\nPress any key to go back!");
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                case 3:
                    exportByGreaterThanFive();
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                case 4:
                    exportByAscent();
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                case 5:
                    exportByGreaterThanFiveAndIT();
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                case 6:
                    exportByHighest();
                    Console.ReadKey();
                    Console.Clear();
                    exportStudentMenu();
                    break;
                default:
                    menu();
                    break;
            }
        }

        static void menu()
        {
            int choice;
            Console.WriteLine("Manage Student");
            Console.WriteLine("1. Add student.");
            Console.WriteLine("2. Export student");
            Console.WriteLine("0. Exit");
            Console.WriteLine("------------");
            Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    addStudent();
                    Console.WriteLine("\nPress any key to go back!");
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    exportStudentMenu();
                    Console.WriteLine("\nPress any key to go back!");
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
    }
}
