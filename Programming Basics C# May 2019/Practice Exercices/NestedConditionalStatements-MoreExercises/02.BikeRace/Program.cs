using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();

            double taxJuniors = 0;
            double taxSeniors = 0;
            double totalParticipants = juniors + seniors;
            double totalTax = 0;

            if (traceType == "trail")
            {
                taxJuniors = juniors * 5.5;
                taxSeniors = seniors * 7;
                totalTax = taxJuniors + taxSeniors;
            }
            else if (traceType == "cross-country")
            {
                taxJuniors = juniors * 8;
                taxSeniors = seniors * 9.5;
                totalTax = taxJuniors + taxSeniors;
                if (totalParticipants >= 50)
                {
                    totalTax *= 0.75;
                }
            }
            else if (traceType == "downhill")
            {
                taxJuniors = juniors * 12.25;
                taxSeniors = seniors * 13.75;
                totalTax = taxJuniors + taxSeniors;
            }
            else if (traceType == "road")
            {
                taxJuniors = juniors * 20;
                taxSeniors = seniors * 21.5;
                totalTax = taxJuniors + taxSeniors;
            }
            totalTax *= 0.95;
            Console.WriteLine($"{totalTax:f2}");
        }
    }
}