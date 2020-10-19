using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int ageCount = 18;

            double neededMoney = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    neededMoney += 12000;
                }
                else
                {
                    neededMoney += 12000 + (50 * ageCount);
                }
                ageCount++;
            }
            double diff = Math.Abs(heritageMoney - neededMoney);

            if (heritageMoney >= neededMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
        }
    }
}