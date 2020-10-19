using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tableCount = double.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double coverSize = (tableWidth+0.6) * (tableLength+0.6);
            double squareSize = (tableLength / 2) * (tableLength / 2);

            double coverPrice = coverSize * 7;
            double squarePrice = squareSize * 9;

            double totalPriceInUSD = tableCount * (coverPrice + squarePrice);
            double totalPriceInBGN = totalPriceInUSD * 1.85;

            Console.WriteLine($"{totalPriceInUSD:f2} USD");
            Console.WriteLine($"{totalPriceInBGN:f2} BGN");
        }
    }
}
