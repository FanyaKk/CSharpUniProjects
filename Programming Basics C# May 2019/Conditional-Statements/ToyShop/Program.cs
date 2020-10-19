using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacancyCost = double.Parse(Console.ReadLine());
            double puzzle = double.Parse(Console.ReadLine());
            double doll = double.Parse(Console.ReadLine());
            double teddyBear = double.Parse(Console.ReadLine());
            double minion = double.Parse(Console.ReadLine());
            double truck = double.Parse(Console.ReadLine());

            double puzzlePrice = puzzle * 2.60;
            double dollPrice = doll * 3;
            double teddyBearPrice = teddyBear * 4.10;
            double minionPrice = minion * 8.20;
            double truckPrice = truck * 2;

            double toysTotalPrice = puzzlePrice + dollPrice + teddyBearPrice + minionPrice + truckPrice;

            double toysCount = puzzle + doll + teddyBear + minion + truck;
            toysTotalPrice *= 0.9;

            if (toysCount >= 50)
            {
                toysTotalPrice *= 0.75;
            }
            if (toysTotalPrice >= vacancyCost)
            {
                double leftMoney = toysTotalPrice - vacancyCost;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else
            {
                double needMoney = vacancyCost - toysTotalPrice;
                Console.WriteLine($"Not enough money! {needMoney:f2} lv needed.");
            }
        }
    }
}
