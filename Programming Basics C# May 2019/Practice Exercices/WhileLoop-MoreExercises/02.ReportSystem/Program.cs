using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int charitySum = int.Parse(Console.ReadLine());

            int payCounter = 0;

            int cashCounter = 0;
            int cardCounter = 0;

            double cashSum = 0;
            double cardSum = 0;

            double averageCashSum = 0;
            double averageCardSum = 0;

            double totalSum = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int articlePrice = int.Parse(command);
                payCounter++;

                if (payCounter % 2 == 0)
                {
                    if (articlePrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cardCounter++;
                        cardSum += articlePrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (articlePrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cashCounter++;
                        cashSum += articlePrice;
                        Console.WriteLine("Product sold!");
                    }
                }

                totalSum = cashSum + cardSum;

                if (totalSum >= charitySum)
                {
                    averageCashSum = cashSum / cashCounter;
                    averageCardSum = cardSum / cardCounter;
                    Console.WriteLine($"Average CS: {averageCashSum:f2}");
                    Console.WriteLine($"Average CC: {averageCardSum:f2}");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}