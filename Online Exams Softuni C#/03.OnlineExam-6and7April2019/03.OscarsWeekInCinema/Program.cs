using System;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hallType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (movie == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    price = tickets * 7.5;
                }
                else if (hallType == "luxury")
                {
                    price = tickets * 10.5;
                }
                else if (hallType == "ultra luxury")
                {
                    price = tickets * 13.5;
                }
            }
            else if (movie == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    price = tickets * 7.35;
                }
                else if (hallType == "luxury")
                {
                    price = tickets * 9.45;
                }
                else if (hallType == "ultra luxury")
                {
                    price = tickets * 12.75;
                }
            }
            else if (movie == "Green Book")
            {
                if (hallType == "normal")
                {
                    price = tickets * 8.15;
                }
                else if (hallType == "luxury")
                {
                    price = tickets * 10.25;
                }
                else if (hallType == "ultra luxury")
                {
                    price = tickets * 13.25;
                }
            }
            else if (movie == "The Favourite")
            {
                if (hallType == "normal")
                {
                    price = tickets * 8.75;
                }
                else if (hallType == "luxury")
                {
                    price = tickets * 11.55;
                }
                else if (hallType == "ultra luxury")
                {
                    price = tickets * 13.95;
                }
            }
            Console.WriteLine($"{movie} -> {price:f2} lv.");
        }
    }
}
