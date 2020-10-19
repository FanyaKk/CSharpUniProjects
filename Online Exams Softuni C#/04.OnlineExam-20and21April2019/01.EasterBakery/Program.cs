using System;

namespace _01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPriceKilo = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsDosenCount = int.Parse(Console.ReadLine());
            int mayPackages = int.Parse(Console.ReadLine());

            double sugarPriceKilo = flourPriceKilo * 0.75;
            double eggsDosePrice = flourPriceKilo + flourPriceKilo * 0.1;
            double mayPackagePrice = sugarPriceKilo * 0.2;

            double totalFlourPrice = flourKg * flourPriceKilo;
            double totalSugarPrice = sugarKg * sugarPriceKilo;
            double totalEggsPrice = eggsDosePrice * eggsDosenCount;
            double totalMayPrice = mayPackages * mayPackagePrice;

            double totalSum = totalFlourPrice + totalSugarPrice + totalEggsPrice + totalMayPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
