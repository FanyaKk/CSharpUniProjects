using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistics = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (statistics > 150)
            {
                clothes *= 0.9;
            }

            double moneyForDecorClothes = (statistics * clothes) + decor;

            if (moneyForDecorClothes > budget)
            {
                double neededMoney = moneyForDecorClothes - budget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else if (moneyForDecorClothes <= budget)
            {
                double leftMoney = budget - moneyForDecorClothes;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
        }
    }
}
