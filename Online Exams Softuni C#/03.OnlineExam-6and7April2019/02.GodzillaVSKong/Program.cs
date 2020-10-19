using System;

namespace _02.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extraActors = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double clothesPrice = extraActors * priceForClothes;
            if (extraActors > 150)
            {
                clothesPrice *= 0.9;
            }
            double totalPrice = clothesPrice + decorPrice;
            double diff = Math.Abs(budget - totalPrice);
            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
            }
        }
    }
}
