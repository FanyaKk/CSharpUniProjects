using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int kmPerMonth = int.Parse(Console.ReadLine());

            double totalKm = kmPerMonth * 4;


            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    totalKm *= 0.75;
                }
                else if (season == "Summer")
                {
                    totalKm *= 0.9;
                }
                else if (season == "Winter")
                {
                    totalKm *= 1.05;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    totalKm *= 0.95;
                }
                else if (season == "Summer")
                {
                    totalKm *= 1.1;
                }
                else if (season == "Winter")
                {
                    totalKm *= 1.25;
                }
            }
            else if (kmPerMonth <= 20000)
            {
                totalKm *= 1.45;
            }

            double salary = totalKm * 0.9;

            Console.WriteLine($"{salary:f2}");
        }
    }
}
