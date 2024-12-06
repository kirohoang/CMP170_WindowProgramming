using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class Program
    {
        static int result = 1;
        static int factorial(int n)
        {
            if (n == 0) 
                return result;
            result *= n;
            return factorial(n - 1);
        }

        static void Sxn(int x, int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(x, i) / factorial(i);
            }
            Console.WriteLine($"Result S({x},{n}) = {result}");
        }

        static void Main(string[] args)
        {
            int x, n;
            Console.Write("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Sxn(x, n);
            Console.ReadKey();
        }
    }
}
