using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForVegetable = double.Parse(Console.ReadLine());
            double priceForFruit = double.Parse(Console.ReadLine());
            double totalValueVegetables = double.Parse(Console.ReadLine());
            double totalValueFruit = double.Parse(Console.ReadLine());

            double totalPriceForVegetables = priceForVegetable * totalValueVegetables;
            double totalPriceForFruit = priceForFruit * totalValueFruit;

            double totalPrice = (totalPriceForVegetables + totalPriceForFruit) / 1.94;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
