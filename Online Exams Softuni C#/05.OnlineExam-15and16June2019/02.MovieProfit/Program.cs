using System;

namespace _02.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int ticketsPerDay = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            double movieProfit = ticketsPerDay * ticketPrice * days;
            double profitForCinema = movieProfit * percentForCinema / 100;
            double totalMovieProfit = movieProfit - profitForCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {totalMovieProfit:f2} lv.");
        }
    }
}
