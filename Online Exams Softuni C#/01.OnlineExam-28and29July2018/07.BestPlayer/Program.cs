using System;

namespace _07.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string playerName = "";
            int numberOfGoals = 0;

            string topPlayer = "";
            int moreGoal = 0;

            while (command != "END")
            {
                playerName = command;
                numberOfGoals = int.Parse(Console.ReadLine());

                if (moreGoal < numberOfGoals)
                {
                    moreGoal = numberOfGoals;
                    topPlayer = playerName;
                }
                if (numberOfGoals >= 10)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (moreGoal >= 3)
            {
                Console.WriteLine($"{topPlayer} is the best player!");
                Console.WriteLine($"He has scored {moreGoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{topPlayer} is the best player!");
                Console.WriteLine($"He has scored {moreGoal} goals.");
            }
        }
    }
}
