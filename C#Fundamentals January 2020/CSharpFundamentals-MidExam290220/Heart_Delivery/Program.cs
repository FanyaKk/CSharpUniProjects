using System;
using System.Collections.Generic;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string command = "";
            int cupidStop = 0;
            int housesSum = 0;
            int failedCount = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] input = command.Split().ToArray();
                string action = input[0];
                int length = int.Parse(input[1]) % houses.Count;

                if(action == "Jump")
                {
                    for (int i = 0; i < length; i++)
                    {
                        cupidStop++;
                    }
                    if (cupidStop >= houses.Count)
                    {
                        cupidStop = 0;
                    }
                    houses[cupidStop] -= 2;
                    if (houses[cupidStop] == 0)
                    {
                        Console.WriteLine($"Place {cupidStop} has Valentine's day.");
                    }
                    else if (houses[cupidStop] < 0)
                    {
                        houses[cupidStop] = 0;
                        Console.WriteLine($"Place {cupidStop} already had Valentine's day.");
                    }
                }
            }
            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] > 0)
                {
                    failedCount++;
                }
                housesSum += houses[i];
            }
            if (command == "Love!")
            {
                Console.WriteLine($"Cupid's last position was {cupidStop}.");
            }
            if (housesSum == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCount} places.");
            }
        }
    }
}
