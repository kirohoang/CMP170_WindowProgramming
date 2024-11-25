using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Thư mục hiện tại: " + currentDirectory);

            // Lùi lại 1 cấp
            string parentDirectory = Path.GetFullPath(Path.Combine(currentDirectory, ".."));
            Console.WriteLine("Thư mục cha: " + parentDirectory);

            // Lùi lại 2 cấp
            string grandParentDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "..", ".."));
            Console.WriteLine("Thư mục cha của thư mục cha: " + grandParentDirectory);

            Console.ReadKey();
        }
    }
}
