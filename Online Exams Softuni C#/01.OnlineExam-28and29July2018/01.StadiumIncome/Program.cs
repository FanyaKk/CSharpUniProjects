using System;

namespace _01.StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double sectorPrice = stadiumCapacity * ticketPrice / sectors;
            double partOfSectorPrice = sectorPrice * 0.75;
            double stadiumPrice = stadiumCapacity * ticketPrice;

            //double partOfStadiumPrice = stadiumPrice * 12.5;

            double moneyForCharity = (stadiumPrice - partOfSectorPrice) * 0.125;

            Console.WriteLine($"Total income - {stadiumPrice:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");

        }
    }
}
