using System;

namespace _01.MatchTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int fens = int.Parse(Console.ReadLine());

            if (fens <= 4)
            {
                budget *= 0.25;
            }
            else if (fens <= 9)
            {
                budget *= 0.4;
            }
            else if (fens <= 24)
            {
                budget *= 0.5;
            }
            else if (fens <= 49)
            {
                budget *= 0.60;
            }
            else if (fens >= 50)
            {
                budget *= 0.75;
            }
            if (ticketCategory == "VIP")
            {
                double leftMoney = Math.Abs(budget - (fens * 499.99));
                if (budget >= fens * 499.99)
                {
                    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {leftMoney:f2} leva.");
                }
            }
            else if (ticketCategory == "Normal")
            {
                double leftMoney = Math.Abs(budget - (fens * 249.99));
                if (budget >= fens * 249.99)
                {
                    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {leftMoney:f2} leva.");
                }
            }
        }
    }
}