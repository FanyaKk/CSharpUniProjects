using System;

namespace _05.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieProjection = Console.ReadLine();
            string moviePack = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            if (movieProjection== "John Wick")
            {
                if (moviePack == "Drink")
                {
                    totalPrice = tickets * 12;
                }
                else if (moviePack == "Popcorn")
                {
                    totalPrice = tickets * 15;
                }
                else if (moviePack == "Menu")
                {
                    totalPrice = tickets * 19;
                }
            }
            else if (movieProjection == "Star Wars")
            {
                if (moviePack == "Drink")
                {
                    totalPrice = tickets * 18;
                }
                else if (moviePack == "Popcorn")
                {
                    totalPrice = tickets * 25;
                }
                else if (moviePack == "Menu")
                {
                    totalPrice = tickets * 30;
                }
                if (tickets >= 4)
                {
                    totalPrice *= 0.7;
                }
            }
            else if (movieProjection == "Jumanji")
            {
                if (moviePack == "Drink")
                {
                    totalPrice = tickets * 9;
                }
                else if (moviePack == "Popcorn")
                {
                    totalPrice = tickets * 11;
                }
                else if (moviePack == "Menu")
                {
                    totalPrice = tickets * 14;
                }
                if (tickets == 2)
                {
                    totalPrice *= 0.85;
                }
            }
            Console.WriteLine($"Your bill is {totalPrice:F2} leva.");
        }
    }
}
