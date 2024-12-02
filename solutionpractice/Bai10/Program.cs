using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Program
    {
        /*
            Vừa gà vừa chó
            Bó lại cho tròn
            Ba mươi sáu con
            Một trăm chân chẵn
         */
        static void Main(string[] args)
        {
            /*
            x + y = 36
            2x + 4y = 100   
             */
            int x = 0;
            int y = 0;
            for (int i = 1; i <= 36; i++)
            {
                x = i;
                y = 36 - x;

                if (2 * x + 4 * y == 100)
                    break;
            }
            Console.WriteLine($"Chickens: {x}\n" + $"Dogs: {y}");
            Console.ReadKey();
        }
    }
}
