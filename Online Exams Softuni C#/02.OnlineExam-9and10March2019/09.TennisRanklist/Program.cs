using System;

namespace _09.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournament = int.Parse(Console.ReadLine());
            int initalScore = int.Parse(Console.ReadLine());
            int score = 0;
            double winTournament = 0;

            for (int i = 0; i < numberOfTournament; i++)
            {
                string tournamentStage = Console.ReadLine();
                if (tournamentStage == "W")
                {
                    score += 2000;
                    winTournament++;
                }
                else if (tournamentStage == "F")
                {
                    score += 1200;
                }
                else if (tournamentStage == "SF")
                {
                    score += 720;
                }
            }
            int finalScore = initalScore + score;
            double averageScore = score / numberOfTournament;
            double winsInPercents = winTournament / numberOfTournament * 100;

            Console.WriteLine($"Final points: {finalScore}");
            Console.WriteLine($"Average points: {Math.Ceiling(averageScore)}");
            Console.WriteLine($"{winsInPercents:f2}%");
        }
    }
}
