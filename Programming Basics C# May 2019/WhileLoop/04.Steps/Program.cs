using System;

namespace _04.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int totalSteps = 0;

            while (totalSteps < 10000)
            {                
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    totalSteps = steps;
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    if (totalSteps < 10000)
                    {
                        int diff = 10000 - totalSteps;
                        Console.WriteLine($"{diff} more steps to reach goal.");
                        break;
                    }
                }
                else if (command != "Going home")
                {
                    steps += int.Parse(command);
                    totalSteps = steps;
                }
            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
