using System;

namespace _10.GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int numberOfMatches = int.Parse(Console.ReadLine());

            int penaltiesCount = 0;
            int addMatchCount = 0;

            int totalTime = 0;
            int averageTime = 0;


            for (int i = 1; i <= numberOfMatches; i++)
            {
                int time = int.Parse(Console.ReadLine());

                if (time > 120)
                {
                    penaltiesCount++;
                }
                else if (time > 90)
                {
                    addMatchCount++;
                }
                totalTime += time;
            }
            averageTime = totalTime / numberOfMatches;

            Console.WriteLine($"{teamName} has played {totalTime} minutes. Average minutes per game: {averageTime:f2}");
            Console.WriteLine($"Games with penalties: {penaltiesCount}");
            Console.WriteLine($"Games with additional time: {addMatchCount}");
        }
    }
}
