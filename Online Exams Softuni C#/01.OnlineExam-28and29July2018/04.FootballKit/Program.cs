using System;

namespace _04.FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirtPrice = double.Parse(Console.ReadLine());
            double neededAmountForGainABall = double.Parse(Console.ReadLine());

            double shorts = shirtPrice * 0.75;
            double socks = shorts * 0.2;
            double shoes = (shorts + shirtPrice) * 2;

            double totalAmount = shirtPrice + shorts + socks + shoes;
            totalAmount *= 0.85;

            if (totalAmount >= neededAmountForGainABall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalAmount:f2} lv.");
            }
            else
            {
                double neededMoney = neededAmountForGainABall - totalAmount;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededMoney:f2} lv. more.");
            }
        }
    }
}