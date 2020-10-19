using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsOutOfSofia = double.Parse(Console.ReadLine());

            double weekndsInSofia = (48 - weekendsOutOfSofia) * 3 / 4;
            double playsInHolidays = holidays * 2 / 3;

            double totalPlays = weekendsOutOfSofia + weekndsInSofia + playsInHolidays;

            if (yearType == "leap")
            {
                totalPlays += totalPlays * 0.15;
                Console.WriteLine($"{Math.Floor(totalPlays)}");
            }
            else if (yearType == "normal")
            {
                Console.WriteLine($"{Math.Floor(totalPlays)}");
            }
        }
    }
}
