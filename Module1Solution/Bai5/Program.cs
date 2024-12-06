using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        public static void FirstDegreeEquation(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {

                Console.WriteLine("Phuong trinh co 1 nghiem {0}", (double)-b / a);
            }
        }
        public static void SecondDegreeEquation(int a, int b, int c)
        {
            double delta = 0;
            double x, y;
            if (a == 0)
            {
                FirstDegreeEquation(b, c);
            }
            else
            {
                delta = (double)Math.Pow(b, 2) - 4 * a * c;
                if (delta == 0)
                {
                    Console.WriteLine("Phuong Trinh co 1 nghiem " + (double)-b / 2 * a);
                }
                else if (delta > 0)
                {
                    x = (-b + Math.Sqrt(delta)) / (2 * a);
                    y = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong Trinh co 2 nghiem: ");
                    Console.WriteLine("X = {0}, Y = {1}", Math.Round(x, 2), Math.Round(y, 2));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            SecondDegreeEquation(a, b, c);
            Console.ReadKey();
        }
    }
}
