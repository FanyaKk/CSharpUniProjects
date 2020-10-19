using System;

namespace _05.Company
{
    class Program
    {
        static void Main(string[] args)
        {
            double timeForProject = double.Parse(Console.ReadLine());
            double companyDays = double.Parse(Console.ReadLine());
            int laborers = int.Parse(Console.ReadLine());

            double timeWithoutStudy = companyDays * 0.9;
            double havingHours = timeWithoutStudy * 8;
            double laborersOverTime = laborers * 2 * companyDays;
            havingHours += laborersOverTime;
            double restOfHours = Math.Floor(havingHours - timeForProject);

            if (timeForProject <= havingHours)
            {
                Console.WriteLine($"Yes!{restOfHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Abs(restOfHours)} hours needed.");
            }
        }
    }
}