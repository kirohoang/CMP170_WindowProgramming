using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = 0;
            double goc;
            Console.WriteLine("***CAC HAM LUONG GIAC***");
            Console.WriteLine("Nhap Vao 1 Goc: ");
            goc = Convert.ToInt32(Console.ReadLine());
            rad = goc * Math.PI / 180;
            Console.WriteLine("Sin({0})={1}", goc, Math.Sin(rad));
            Console.WriteLine("Cos({0})={1}", goc, Math.Cos(rad));
            Console.WriteLine("Tan({0})={1}", goc, Math.Tan(rad));
            Console.WriteLine("CogTan({0})={1}", goc, 1 / Math.Tan(rad));
            Console.ReadLine();
        }
    }
}
