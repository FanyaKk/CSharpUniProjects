using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double overnights = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = overnights * 50;
                apartmentPrice = overnights * 65;
                if (overnights > 7 && overnights <= 14)
                {
                    studioPrice *= 0.95;
                }
                else if (overnights > 14)
                {
                    studioPrice *= 0.7;
                    apartmentPrice *= 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = overnights * 75.20;
                apartmentPrice = overnights * 68.70;
                if (overnights > 14)
                {
                    studioPrice *= 0.8;
                    apartmentPrice *= 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = overnights * 76;
                apartmentPrice = overnights * 77;
                if (overnights > 14)
                {
                    apartmentPrice *= 0.9;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
