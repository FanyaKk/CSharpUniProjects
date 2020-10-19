using System;

namespace _03.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();

            int inGoal1 = firstMatch[0];
            int scoredGoal1 = firstMatch[2];

            int inGoal2 = secondMatch[0];
            int scoredGoal2 = secondMatch[2];

            int inGoal3 = thirdMatch[0];
            int scoredGoal3 = thirdMatch[2];

            int win = 0;
            int losses = 0;
            int drawn = 0;


            if (inGoal1 > scoredGoal1)
            {
                win++;
            }
            else if (inGoal1 < scoredGoal1)
            {
                losses++;
            }
            else if (inGoal1 == scoredGoal1)
            {
                drawn++;
            }
            if (inGoal2 > scoredGoal2)
            {
                win++;
            }
            else if (inGoal2 < scoredGoal2)
            {
                losses++;
            }
            else if (inGoal2 == scoredGoal2)
            {
                drawn++;
            }
            if (inGoal3 > scoredGoal3)
            {
                win++;
            }
            else if (inGoal3 < scoredGoal3)
            {
                losses++;
            }
            else if (inGoal3 == scoredGoal3)
            {
                drawn++;
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {losses} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
