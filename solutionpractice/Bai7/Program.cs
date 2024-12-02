using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double perimeter, area, p;
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C: ");
            c = Convert.ToInt32(Console.ReadLine());
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
            Console.ReadKey();
        }
    }
}
