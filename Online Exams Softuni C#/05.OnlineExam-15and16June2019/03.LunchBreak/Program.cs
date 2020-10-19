using System;

namespace _03.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            double serialTime = double.Parse(Console.ReadLine());
            double breakTime = double.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8;
            double restTime = breakTime / 4;

            double remainingTime = breakTime - (lunchTime + restTime);
            double leftTime = Math.Ceiling(Math.Abs(remainingTime - serialTime));

            if (remainingTime >= serialTime)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {leftTime} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {leftTime} more minutes.");
            }
        }
    }
}
