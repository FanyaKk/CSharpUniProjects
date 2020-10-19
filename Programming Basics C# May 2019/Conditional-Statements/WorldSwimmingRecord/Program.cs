using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeForAllMeters = timeForOneMeter * meters;
            double waterResistaance = Math.Floor(meters / 15);
            double extraTime = waterResistaance * 12.5;
            double totalTime = timeForAllMeters + extraTime;

            if (record > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else if (record <= totalTime)
            {
                double shortageOfTime = totalTime - record;
                Console.WriteLine($"No, he failed! He was {shortageOfTime:f2} seconds slower.");
            }
        }
    }
}
