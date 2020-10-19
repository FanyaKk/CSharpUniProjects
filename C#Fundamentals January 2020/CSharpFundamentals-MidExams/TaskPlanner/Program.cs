using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasksHour = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split().ToArray();
                if(input[0] == "Complete")
                {
                    int completeIndex = int.Parse(input[1]);
                    if (completeIndex >= 0 && completeIndex < tasksHour.Count)
                    {
                        tasksHour[completeIndex] = 0;
                    }
                }
                else if (input[0] == "Change")
                {
                    int changeIndex = int.Parse(input[1]);
                    if(changeIndex >= 0 && changeIndex < tasksHour.Count)
                    {
                        tasksHour[changeIndex] = int.Parse(input[2]);
                    }
                }
                else if (input[0] == "Drop")
                {
                    int droppedIndex = int.Parse(input[1]);
                    if (droppedIndex >= 0 && droppedIndex < tasksHour.Count)
                    {
                        tasksHour[droppedIndex] = -1;
                    }
                }
                else if (command == "Count Completed")
                {
                    int completeCount = 0;
                    for (int i = 0; i < tasksHour.Count; i++)
                    {
                        if (tasksHour[i] == 0)
                        {
                            completeCount++;
                        }
                    }
                    Console.WriteLine(completeCount);
                }
                else if (command == "Count Incomplete")
                {
                    int incompleteCount = 0;
                    for (int i = 0; i < tasksHour.Count; i++)
                    {
                        if (tasksHour[i] > 0)
                        {
                            incompleteCount++;
                        }
                    }                   
                    Console.WriteLine(incompleteCount);

                }
                else if (command == "Count Dropped")
                {
                    int droppedCount = 0;
                    for (int i = 0; i < tasksHour.Count; i++)
                    {
                        if (tasksHour[i] < 0)
                        {
                            droppedCount++;
                        }
                    }
                    Console.WriteLine(droppedCount);
                }
            }
            for (int i = 0; i < tasksHour.Count; i++)
            {
                if (tasksHour[i] <= 0)
                {
                    tasksHour.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", tasksHour));
        }
    }
}
