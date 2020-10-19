using System;

namespace _02.TripToWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketPriceTo = double.Parse(Console.ReadLine());
            double ticketPriceBack = double.Parse(Console.ReadLine());
            double matchTicketPrice = double.Parse(Console.ReadLine());
            double matches = double.Parse(Console.ReadLine());
            double discountInPercents = double.Parse(Console.ReadLine());


            double matchesPriceForAll = 6 * matches * matchTicketPrice;
            double ticketTotalPrice = 6 * (ticketPriceTo + ticketPriceBack) * (1 - discountInPercents / 100);
            double totalPrice = matchesPriceForAll + ticketTotalPrice;

            double totalPriceForOne = totalPrice / 6;

            Console.WriteLine($"Total sum: {totalPrice:f2} lv");
            Console.WriteLine($"Each friend has to pay {totalPriceForOne:f2} lv.");
        }
    }
}
