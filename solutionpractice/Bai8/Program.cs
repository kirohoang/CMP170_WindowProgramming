using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {

        // Triangle
        static void calculateTriangle( int a, int b, int c)
        {
            // Using Heron Formula in case that 3 sides are known
            double perimeter, area, p;
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c || a + c > b || b + c > a)
                {
                    perimeter = a + b + c;
                    p = perimeter / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("Perimeter: " + perimeter);
                    Console.WriteLine("Area: " + area);
                }
                else
                    Console.WriteLine("Could not create a triangle");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        // Rectangle
        static void calculateRectangle(int a, int b)
        {
            double perimeter, area;
            if (a > 0 && b > 0)
            {
                perimeter = (a + b) * 2;
                area = a * b;

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        // Square
        static void calculateSquare(int a)
        {
            if (a > 0)
            {
                double perimeter, area;
                perimeter = 4 * a;
                area = a * a;

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        
        // Circle
        static void calculateCircle(double radius)
        {
            double perimeter, area;
            if (radius > 0)
            {
                perimeter = 2 * Math.PI * radius;
                area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        static void menu()
        {
            int a, b, c;
            double radius;
            int choice;
            Console.WriteLine("1. Calculate Triangle\n" +
                                "2. Calculate Rectangle\n" +
                                "3. Calculate Square\n" +
                                "4. Calculate Circle\n" +
                                "0. Exit" );
            Console.Write("Enter: ");
            choice = Convert.ToInt32( Console.ReadLine() );
            switch ( choice )
            {
                case 1:
                    Console.Write("Enter A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter C: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    calculateTriangle(a, b, c);
                    break;
                case 2:
                    Console.Write("Enter A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    calculateRectangle(a, b);
                    break;
                case 3:
                    Console.Write("Enter A: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    calculateSquare(a);
                    break;
                case 4:
                    Console.Write("Enter A: ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    calculateCircle(radius);
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
