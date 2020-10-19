﻿using System;

namespace _04.RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "";
            string carType = "";
            double carPrice = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 0.80;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                carPrice = budget * 0.90;
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {carPrice:f2}");
        }
    }
}
