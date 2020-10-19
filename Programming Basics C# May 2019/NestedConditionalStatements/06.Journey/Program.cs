using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spendMoney = 0;
            string destination = "";
            string jorneyType = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                    jorneyType = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                    jorneyType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spendMoney = budget * 0.4;
                    jorneyType = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                    jorneyType = "Hotel";
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                spendMoney = budget * 0.9;
                jorneyType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{jorneyType} - {spendMoney:f2}");
        }
    }
}
