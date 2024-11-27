using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_HoangChiTrung
{
    internal class Program
    {
        static string targetNumber()
        {
            Random random = new Random();
            return random.Next(100, 1000).ToString();
        }
        static string getFeedBack(string target, string guess)
        {
            string feedBack = "";

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == target[i])
                {
                    return feedBack += "+";
                }
                else if (target.Contains(guess[i]))
                {
                    return feedBack + "?";
                }
            }

            return feedBack;
        }
        static void Main(string[] args)
        {
            string guessNumber;
            Console.WriteLine("Enter 3 digits number");
            guessNumber = Console.ReadLine();

            int attempt = 1;
            string targetNumberString = targetNumber();
            string guess = "", feedBack = "";
            while (feedBack != "+++" && attempt < 7)
            {
                Console.WriteLine($"Number of times {attempt}");
                guess = Console.ReadLine();
                if (guess != null)
                {
                    feedBack = getFeedBack(targetNumberString, guess);
                }
                Console.WriteLine($"Computer feedback {feedBack}");
                attempt++;
            }
            if (attempt == 7)
            {
                Console.WriteLine($"FAILURE!!, the number is {targetNumberString}");
            }
            else
            {
                Console.WriteLine($"WINNER, guesses is {attempt}");
            }
            Console.ReadKey();
        }
    }
}
