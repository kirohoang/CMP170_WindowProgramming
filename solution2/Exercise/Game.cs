using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Game
    {
        public int tickets;
        public int ticket_prices = 4;
        bool picked_numbers;
        string player_answer;
        int[] player_ticket_numbers = new int[6];
        int[] ticket_result = new int[6];
        int count = 0;

        Player player = new Player();
        Random rand = new Random();

        public void randomNumber()
        {
            for (int i = 0; i < 6; i++)
            {
                player_ticket_numbers[i] = rand.Next(1, 50);
                Console.Write(player_ticket_numbers[i] + " ");
            }
        }

        public void output_number_ticket()
        {
            for (int i = 0; i < player_ticket_numbers.Length; i++)
            {
                Console.Write(player_ticket_numbers[i] + " ");
            }
        }

        public void result()
        {
            for (int i = 0; i < 6; i++)
            {
                ticket_result[i] = rand.Next(1, 50);
                Console.Write(ticket_result[i] + " ");
            }

        }

        public void compared()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (player_ticket_numbers[i] == ticket_result[j])
                    {
                        count++;
                    }
                }
            }
            if (count == 1 || count == 2)
            {
                player.won_money += 10;
            }
            else if (count == 3)
            {
                player.won_money += 100;
            }
            else if (count == 4)
            {
                player.won_money += 1000;
            }
            else if (count == 5)
            {
                player.won_money += 5000;
            }
            else if (count == 6)
            {
                player.won_money += 5000000;
            }
            else
            {
                Console.WriteLine("\nYou lose :(");
            }
            Console.WriteLine($"\nYour ticket has matched {count} number(s)");
            Console.WriteLine($"You have won {player.won_money}$");
            player.money += player.won_money;
        }

        public void input()
        {
            Console.Write("Enter your money to play: ");
            player.money = Convert.ToInt32(Console.ReadLine());
            if (player.money < 1)
            {
                Console.WriteLine("You are too broken to afford the gameplay!");
                Console.WriteLine("Comeback when you have got some money");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("How many games do you want to play? ");
                tickets = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < tickets; i++)
                {
                    Console.WriteLine("\nDo you want to pick your own number (Yes or No):");
                    player_answer = Console.ReadLine();
                    if (player_answer.Equals("Yes") || player_answer.Equals("yes"))
                    {
                        for (int j = 0; j < player_ticket_numbers.Length; j++)
                        {
                            Console.Write($"Enter your {j + 1} ticker number from (1-49): ");
                            player_ticket_numbers[j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else if (player_answer.Equals("No") || player_answer.Equals("no"))
                    {
                        Console.Write("Your ticket numbers: ");
                        randomNumber();
                    }
                    else
                    {
                        Console.WriteLine("You entered an invalid value. Please try again!");
                        Console.ReadKey();
                        Console.Clear();
                        input();
                    }
                    Console.Write("\nYou picked numbers: ");
                    output_number_ticket();

                    Console.Write("\nThe winning ticket is: ");
                    result();

                    compared();
                }
                ticket_prices *= tickets;
                player.won_money -= ticket_prices;
                Console.Write($"Profit/Loss (won-cost): {player.won_money}$");

                if (player.money < 4)
                {
                    Console.WriteLine("You don't a");
                }
            }
        }
        public void execute()
        {
            input();
            Console.ReadKey();
        }
    }
}
