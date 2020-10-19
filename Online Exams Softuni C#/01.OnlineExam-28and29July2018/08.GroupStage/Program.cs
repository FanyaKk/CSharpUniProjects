using System;

namespace _08.GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int numberOfPlays = int.Parse(Console.ReadLine());

            int inGoals = 0;
            int outGoals = 0;

            int score = 0;
            int totalScore = 0;

            int totalInGoals = 0;
            int totalOutGoals = 0;

            bool isRanked = false;

            while (numberOfPlays > 0)
            {
                inGoals = int.Parse(Console.ReadLine());
                outGoals = int.Parse(Console.ReadLine());

                if (inGoals > outGoals)
                {
                    score = 3;
                }
                else if (inGoals == outGoals)
                {
                    score = 1;
                }
                totalScore += score;

                totalInGoals += inGoals;
                totalOutGoals += outGoals;
                numberOfPlays--;
            }
            int goalsDifference = totalInGoals - totalOutGoals;
            if (totalInGoals > totalOutGoals)
            {
                isRanked = true;
            }
            if (isRanked == true)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {totalScore} points.");
                Console.WriteLine($"Goal difference: {goalsDifference}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalsDifference}.");
            }
        }
    }
}
