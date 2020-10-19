using System;

namespace _02.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int tennisRacketCount = int.Parse(Console.ReadLine());
            int sneakersCount = int.Parse(Console.ReadLine());

            double sneakersPrice = tennisRacketPrice / 6;

            double totalTennisPrice = tennisRacketPrice * tennisRacketCount;
            double totalSneakersPrice = sneakersPrice * sneakersCount;

            double otherEquipmentPrice = (totalTennisPrice + totalSneakersPrice) * 0.2;

            double finalPrice = totalTennisPrice + totalSneakersPrice + otherEquipmentPrice;
            double djokovicPrice = finalPrice / 8;
            double sponsorsPrice = finalPrice - djokovicPrice;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djokovicPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorsPrice)}");
        }
    }
}
