using System;

namespace _05.Vacancy
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accommodation = "";
            double vacancyPrice = 0;

            if (budget <= 1000)
            {
                accommodation = "Camp";

                if (season == "Summer")
                {
                    destination = "Alaska";
                    vacancyPrice = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    vacancyPrice = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accommodation = "Hut";

                if (season == "Summer")
                {
                    destination = "Alaska";
                    vacancyPrice = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    vacancyPrice = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                accommodation = "Hotel";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    vacancyPrice = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    vacancyPrice = budget * 0.90;
                }
            }
            Console.WriteLine($"{destination} - {accommodation} - {vacancyPrice:f2}");
        }
    }
}
