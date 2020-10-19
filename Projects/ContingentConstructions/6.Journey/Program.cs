using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double outcome = 0;
            string destination = string.Empty;
            string placeToSleep = string.Empty;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    outcome = budget * 0.3;
                    placeToSleep = "Camp";
                }
                else if (season == "winter")
                {
                    outcome = budget * 0.7;
                    placeToSleep = "Hotel";
                }
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    outcome = budget * 0.4;
                    placeToSleep = "Camp";
                }
                else if (season == "winter")
                {
                    outcome = budget * 0.8;
                    placeToSleep = "Hotel";
                }
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                outcome = budget * 0.9; 
                placeToSleep = "Hotel";
                destination = "Europe";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine("{0} - {1:f2}", placeToSleep, outcome);
        }
    }
}
