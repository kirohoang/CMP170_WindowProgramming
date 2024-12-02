using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        // Viết chương trình giải Phương trình bậc nhất
        static void FirstDegreeEquation(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Many Solutions");
            } else if (a == 0 && b != 0)
            {
                Console.WriteLine("No Solution");
            }
            else
            {
                Console.WriteLine($"Equation have 1 solution {-b/a}");
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            FirstDegreeEquation(a, b);
            Console.ReadKey();
        }
    }
}
