using System;

namespace _08.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int totalScore = 301;
            string field = Console.ReadLine();
            int unsuccessfulShots = 0;
            int successfulShots = 0;

            while (field != "Retire")
            {
                int score = int.Parse(Console.ReadLine());

                if (field == "Single")
                {
                    if(score > totalScore)
                    {
                        unsuccessfulShots++;
                    }
                    else 
                    {
                        successfulShots++;
                        totalScore -= score;
                    }
                }
                else if (field == "Double")
                {
                    score *= 2;
                    if (score > totalScore)
                    {
                        unsuccessfulShots++;
                    }
                    else
                    {
                        successfulShots++;
                        totalScore -= score;
                    }
                }
                else if (field == "Triple")
                {
                    score *= 3;
                    if (score > totalScore)
                    {
                        unsuccessfulShots++;
                    }
                    else
                    {
                        successfulShots++;
                        totalScore -= score;
                    }
                }
                if (totalScore == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
                    break;
                }
                field = Console.ReadLine();
            }
            if(field == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
            }
        }
    }
}
