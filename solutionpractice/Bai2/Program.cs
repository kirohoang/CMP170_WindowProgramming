using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        // Viết chương trình nhập vào tên mình và xuất ra màn hình “Hello + Tên”
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hellos {name}");
            Console.ReadKey();
        }
    }
}
