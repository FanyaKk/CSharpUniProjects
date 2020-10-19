using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeamName = Console.ReadLine();
            double numberOfPlays = double.Parse(Console.ReadLine());

            char resultOfPlay = ' ';

            int wCount = 0;
            int dCount = 0;
            int lcount = 0;

            int points = 0;

            if (numberOfPlays < 1)
            {
                Console.WriteLine($"{footballTeamName} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 0; i < numberOfPlays; i++)
                {
                    resultOfPlay = char.Parse(Console.ReadLine());

                    if (resultOfPlay == 'W')
                    {
                        wCount++;
                        points += 3;
                    }
                    else if (resultOfPlay == 'D')
                    {
                        dCount++;
                        points += 1;
                    }
                    else if (resultOfPlay == 'L')
                    {
                        lcount++;
                    }
                }
                double winRate = wCount / numberOfPlays * 100;
                Console.WriteLine($"{footballTeamName} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wCount}");
                Console.WriteLine($"## D: {dCount}");
                Console.WriteLine($"## L: {lcount}");
                Console.WriteLine($"Win rate: {winRate:f2}%");
            }
        }
    }
}
