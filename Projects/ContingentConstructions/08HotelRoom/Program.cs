using System;

namespace _08HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartment = 0;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceForStudio = nights * 50;
                    priceForApartment = nights * 65;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceForStudio = nights * 50 * 0.95;
                    priceForApartment = nights * 65;
                }
                else if (nights > 14)
                {
                    priceForStudio = nights * 50 * 0.7;
                    priceForApartment = nights * 65 * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    priceForStudio = nights * 75.20;
                    priceForApartment = nights * 68.70;
                }
                else if (nights > 14)
                {
                    priceForStudio = nights * 75.20 * 0.8;
                    priceForApartment = nights * 68.70 * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                priceForStudio = nights * 76;
                priceForApartment = nights * 77;
                }
                else if (nights > 14)
                {
                    priceForStudio = nights * 76;
                    priceForApartment = nights * 77 * 0.9;
                }
            }
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
        }
    }
}
