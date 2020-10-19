using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double boatRent = 0;

            if (season == "Spring")
            {
                boatRent = 3000;
                if (fishers <= 6)
                {
                    boatRent *= 0.9;
                }
                else if (fishers <= 11)
                {
                    boatRent *= 0.85;
                }
                else if (fishers >= 12)
                {
                    boatRent *= 0.75;
                }
                if (fishers % 2 == 0)
                {
                    boatRent -= boatRent * 0.05;
                }
            }
            else if (season == "Summer")
            {
                boatRent = 4200;
                if (fishers <= 6)
                {
                    boatRent *= 0.9;
                }
                else if (fishers <= 11)
                {
                    boatRent *= 0.85;
                }
                else if (fishers >= 12)
                {
                    boatRent *= 0.75;
                }
                if (fishers % 2 == 0)
                {
                    boatRent -= boatRent * 0.05;
                }
            }
            else if (season == "Autumn")
            {
                boatRent = 4200;
                if (fishers <= 6)
                {
                    boatRent *= 0.9;
                }
                else if (fishers <= 11)
                {
                    boatRent *= 0.85;
                }
                else if (fishers >= 12)
                {
                    boatRent *= 0.75;
                }
            }
            else if (season == "Winter")
            {
                boatRent = 2600;
                if (fishers <= 6)
                {
                    boatRent *= 0.9;
                }
                else if (fishers <= 11)
                {
                    boatRent *= 0.85;
                }
                else if (fishers >= 12)
                {
                    boatRent *= 0.75;
                }
                if (fishers % 2 == 0)
                {
                    boatRent -= boatRent * 0.05;
                }
            }
            double neededMoney = Math.Abs(budget - boatRent);
            if (budget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {neededMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}