using System;

namespace _06.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    totalPrice = 45000 * days;
                }
                else if (season == "Summer")
                {
                    totalPrice = 40000 * days;
                }
                totalPrice *= 0.7;
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    totalPrice = 17000 * days;
                }
                else if (season == "Summer")
                {
                    totalPrice = 12500 * days;
                }
                totalPrice += totalPrice * 0.25;
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    totalPrice = 24000 * days;
                }
                else if (season == "Summer")
                {
                    totalPrice = 20250 * days;
                }
            }
            double leftSum = Math.Abs(budget - totalPrice);
            if (budget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {leftSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {leftSum:F2} leva more!");
            }
        }
    }
}

