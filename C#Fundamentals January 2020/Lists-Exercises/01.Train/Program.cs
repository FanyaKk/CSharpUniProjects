using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> input = command.Split().ToList();

                if (input[0] == "Add")
                {
                    AddWagons(wagons, input);
                }
                else
                {
                    AddPassangers(wagons, wagonCapacity, input);
                }
            }
                Console.WriteLine(string.Join(" ", wagons));
        }

        private static void AddWagons(List<int> wagons, List<string> input)
        {
            int passangers = int.Parse(input[1]);
            wagons.Add(passangers);
        }

        private static void AddPassangers(List<int> wagons, int wagonCapacity, List<string> input)
        {
            int passangers = int.Parse(input[0]);
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + passangers <= wagonCapacity)
                {
                    wagons[i] += passangers;
                    break;
                }
            }
        }
    }
}
