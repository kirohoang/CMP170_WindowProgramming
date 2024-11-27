using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung_Exercise2
{
    internal class Program
    {
        static void Exercise2()
        {
            double a, r, p;
            int n;

            Console.WriteLine("Amount Invested: ");
            p = Convert.ToDouble(Console.ReadLine());

            if (p <= 0)
            {
                Console.WriteLine("You have no money to invest! Good Bye");
                return;
            }

            Console.WriteLine("Annual interest rate (Use 0.05 for 5%): ");
            r = Convert.ToDouble(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("You entered an invalid value. Please try again");
                Exercise2();
            }

            Console.WriteLine("Number of years:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("You entered invalid value! Please, try again");
                Exercise2();
            }

            a = p * (1 + r) * n;

            Console.WriteLine($"Amount on deposit at the end of each year: {a}");

        }
        static void Main(string[] args)
        {
            Exercise2();
            Console.ReadKey();
        }
    }
}
