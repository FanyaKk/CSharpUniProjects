using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());

            double palmQuantity = double.Parse(Console.ReadLine());
            double horseMackerelQuantity = double.Parse(Console.ReadLine());
            double musselsQuantity = double.Parse(Console.ReadLine());

            double palmPrice = (mackerelPrice + mackerelPrice * 0.6) * palmQuantity;
            double horseMackerelPrice = (spratPrice + spratPrice * 0.8) * horseMackerelQuantity;
            double musselsPrice = musselsQuantity * 7.5;

            double totalSum = palmPrice + horseMackerelPrice + musselsPrice;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
