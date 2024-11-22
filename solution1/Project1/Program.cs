using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

namespace Project1
{
    internal class Program
    {
        /* Example 1 */
        static void Example1()
        {
            Console.WriteLine("Example 1:");
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\"";

            Console.WriteLine($"{myString} {myInteger}");
        }

        static void Example2()
        {
            /* Math (Arithmetic) */
            /* I'm using simul equation number of 2
             to calculate 
            A + B = 32
            A - B = -12 */
            Console.WriteLine("Example 2:");
            float A = 10;
            float B = 22;
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"B / A  = {B / A}");
            Console.WriteLine($"B % A  = {B % A}");
        }

        static void Example4()
        {
            string userName;
            double num1, num2;
            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}");
            Console.WriteLine("Give me a number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("now give me another number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
            Console.WriteLine($"The result of substracting {num2} from {num1} is {num1 - num2}");
            Console.WriteLine($"The product of {num1} and {num2} is {num1 - num2}");
            Console.WriteLine($"the result of dividing {num1} by {num2} is {num1 / num2}");
            Console.WriteLine($"the remainder after  dividing {num1} by {num2} is {num1 % num2}");
        }

        static void Example5()
        {
            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt && myInt <= 5);

            Console.WriteLine($"Integer less than10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of ther above is true?" + $"{isLessThan10 ^ isBetween0And5}");
        }

        static void Example6()
        {
            string comparison;
            Console.WriteLine("Enter a number: ");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double var2 = Convert.ToDouble(Console.ReadLine());

            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 < var2)
                    comparison = "equal to";

                else
                    comparison = "greater than";
            }
            Console.WriteLine($"The first number is {comparison} " + $"the second number");
        }

        static void Example7()
        {
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
        }

        static void Example8()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                {
                    break;
                }
                Console.WriteLine($"{i++}");
            }
            Console.ReadKey();

            for (i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();


            i = 1;
            do
            {
                Console.WriteLine("{0}", i++);
            } while (i <= 10);
            Console.ReadLine();
        }

        static void Example9()
        {
            int[] numbers = { 1, 2, 3 };


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index " + i + ": " + numbers[i]);
            }


            foreach (int i in numbers)
            {
                Console.WriteLine("Element at value: " + i);
            }

            Console.ReadLine();
        }

        static void Example10()
        {
            int[,] numbers = { { 2, 3, 9 }, { 4, 5, 9 } };
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            //Example1();
            //Example2();
            //Example4();
            //Example5();
            //Example6();
            //Example7();
            //Example8();
            //Example9();
            //Example10();
            Console.ReadKey();
        }
    }
}