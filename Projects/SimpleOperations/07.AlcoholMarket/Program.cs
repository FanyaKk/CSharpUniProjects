 using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double wiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice * 0.5;
            double winePrice = rakiaPrice * 0.6;
            double beerPrice = rakiaPrice * 0.2;

            double rakiaTotalPrice = rakiaPrice * rakiaQuantity;
            double wineTotalPrice = winePrice * wineQuantity;
            double beerTotalPrice = beerPrice * beerQuantity;
            double wiskeyTotalPrice = wiskeyPrice * wiskeyQuantity;

            double totalAmount = rakiaTotalPrice + wineTotalPrice + beerTotalPrice + wiskeyTotalPrice;

            Console.WriteLine($"{totalAmount:f2}");
        }
    }
}
