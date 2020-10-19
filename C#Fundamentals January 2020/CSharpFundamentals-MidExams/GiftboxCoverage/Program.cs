using System;

namespace GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            double numberOfSheetsOfPaper = double.Parse(Console.ReadLine());
            double areaCoversFromOneSheet = double.Parse(Console.ReadLine());

            double boxArea = sideSize * sideSize * 6;
            double quarterCover = Math.Floor(numberOfSheetsOfPaper / 3);
            double quarterCoverArea = quarterCover * (areaCoversFromOneSheet / 4);
            double totalCover = numberOfSheetsOfPaper - quarterCover;
            double totalCoverArea = totalCover * areaCoversFromOneSheet;
            double totalArea = quarterCoverArea + totalCoverArea;

            double coveredAreaInPercentage = totalArea / boxArea * 100;

            Console.WriteLine($"You can cover {coveredAreaInPercentage:f2}% of the box.");
        }
    }
}
