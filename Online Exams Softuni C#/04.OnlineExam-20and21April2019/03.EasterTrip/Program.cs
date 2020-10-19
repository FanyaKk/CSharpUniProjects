using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string vacationPeriod = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double tripPrice = 0.0;

            if (destination == "France")
            {
                if (vacationPeriod == "21-23")
                {
                    tripPrice = nights * 30;
                }
                else if (vacationPeriod == "24-27")
                {
                    tripPrice = nights * 35;
                }
                else if (vacationPeriod == "28-31")
                {
                    tripPrice = nights * 40;
                }
            }
            else if(destination == "Italy")
            {
                if (vacationPeriod == "21-23")
                {
                    tripPrice = nights * 28;
                }
                else if (vacationPeriod == "24-27")
                {
                    tripPrice = nights * 32;
                }
                else if (vacationPeriod == "28-31")
                {
                    tripPrice = nights * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (vacationPeriod == "21-23")
                {
                    tripPrice = nights * 32;
                }
                else if (vacationPeriod == "24-27")
                {
                    tripPrice = nights * 37;
                }
                else if (vacationPeriod == "28-31")
                {
                    tripPrice = nights * 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {tripPrice:F2} leva.");
        }
    }
}
