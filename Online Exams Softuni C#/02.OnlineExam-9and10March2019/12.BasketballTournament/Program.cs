using System;

namespace _12.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();

            int winsCount = 0;
            int lossesCount = 0;

            double winsInPercents = 0;
            double lossesInPercents = 0;
            double totalMatches = 0;

            while (tournamentName != "End of tournaments")
            {
                int matchCount = int.Parse(Console.ReadLine());
                for (int i = 1; i <= matchCount; i++)
                {
                    double scoreDesiTeam = double.Parse(Console.ReadLine());
                    double theOtherTeam = double.Parse(Console.ReadLine());

                    double scoreDiff = Math.Abs(scoreDesiTeam - theOtherTeam);
                    if (scoreDesiTeam > theOtherTeam)
                    {
                        winsCount++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {scoreDiff} points.");
                    }
                    else if (theOtherTeam > scoreDesiTeam)
                    {
                        lossesCount++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {scoreDiff} points.");
                    }
                }
                tournamentName = Console.ReadLine();
            }
            if (tournamentName == "End of tournaments")
            {
                totalMatches = winsCount + lossesCount;
                winsInPercents = winsCount / totalMatches * 100;
                lossesInPercents = lossesCount / totalMatches * 100;
                Console.WriteLine($"{winsInPercents:f2}% matches win");
                Console.WriteLine($"{lossesInPercents:f2}% matches lost");
            }
        }
    }
}
