using System;

namespace _09.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int seriesCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= seriesCount; i++)
            {
                string seriesName = Console.ReadLine();
                double seriesPrice = double.Parse(Console.ReadLine());

                if (seriesName == "Thrones")
                {
                    seriesPrice *= 0.5;
                }
                else if (seriesName == "Lucifer")
                {
                    seriesPrice *= 0.6;
                }
                else if (seriesName == "Protector")
                {
                    seriesPrice *= 0.7;
                }
                else if (seriesName == "TotalDrama")
                {
                    seriesPrice *= 0.8;
                }
                else if (seriesName == "Area")
                {
                    seriesPrice *= 0.9;
                }
                budget -= seriesPrice;
            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):F2} lv. more to buy the series!");
            }
        }
    }
}
