using System;

namespace _03.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isAHoliday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double flowerCount = chrysanthemums + roses + tulips;

            double bouquetPrice = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumsPrice = chrysanthemums * 2;
                rosesPrice = roses * 4.1;
                tulipsPrice = tulips * 2.5;
                bouquetPrice = chrysanthemumsPrice + rosesPrice + tulipsPrice;
                if (isAHoliday == "Y")
                {
                    bouquetPrice += bouquetPrice * 0.15;
                }
                if (season == "Spring" && tulips > 7)
                {
                    bouquetPrice *= 0.95;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumsPrice = chrysanthemums * 3.75;
                rosesPrice = roses * 4.5;
                tulipsPrice = tulips * 4.15;
                bouquetPrice = chrysanthemumsPrice + rosesPrice + tulipsPrice;
                if (isAHoliday == "Y")
                {
                    bouquetPrice += bouquetPrice * 0.15;
                }
                if (season == "Winter" && roses >= 10)
                {
                    bouquetPrice *= 0.9;
                }
            }
            if (flowerCount > 20)
            {
                bouquetPrice *= 0.8;
            }
            Console.WriteLine($"{bouquetPrice + 2:f2}");
        }
    }
}