using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasonsCount = int.Parse(Console.ReadLine());
            int episodesCount = int.Parse(Console.ReadLine());
            double episodeTime = double.Parse(Console.ReadLine());

            double episodeTimeWithAdds = (episodeTime * 0.20) + episodeTime;
            double additionallyTime = seasonsCount * 10;
            double totalTime = (episodeTimeWithAdds * episodesCount * seasonsCount) + additionallyTime;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {totalTime} minutes.");
        }
    }
}
