﻿using System;

namespace _05.GameStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string playerName = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            else if (minutes < 45)
            {
                Console.WriteLine("First half time.");
                if (minutes <= 10)
                {
                    Console.WriteLine($"{playerName} missed a penalty.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{playerName} was injured after the penalty.");
                    }
                }
                else if (minutes <= 35)
                {
                    Console.WriteLine($"{playerName} received yellow card.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{playerName} got another yellow card.");
                    }
                }
                else
                {
                    Console.WriteLine($"{playerName} SCORED A GOAL !!!");
                }
            }
            else if (minutes >= 45)
            {
                Console.WriteLine("Second half time.");
                if (minutes <= 55 && minutes != 45)
                {
                    Console.WriteLine($"{playerName} got a freekick.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{playerName} missed the freekick.");
                    }
                }
                else if (minutes <= 80 && minutes != 45)
                {
                    Console.WriteLine($"{playerName} missed a shot from corner.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{playerName} has been changed with another player.");
                    }
                }
                else if (minutes <= 90 && minutes != 45)
                {
                    Console.WriteLine($"{playerName} SCORED A GOAL FROM PENALTY !!!");
                }
            }
        }
    }
}
