using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split().ToArray();

                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passangers = int.Parse(input[0]);
                        if (wagons[i] + passangers <= wagonCapacity)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
        //static void Main(string[] args)           //version 1.0
        //{
        //    List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    int wagonCapacity = int.Parse(Console.ReadLine());

        //    string command = "";
        //    while ((command = Console.ReadLine()) != "end")
        //    {
        //        List<string> input = command.Split().ToList();

        //        if (input[0] == "Add")
        //        {
        //            AddWagons(wagons, input);
        //        }
        //        else
        //        {
        //            AddPassangers(wagons, wagonCapacity, input);
        //        }
        //    }
        //        Console.WriteLine(string.Join(" ", wagons));
        //}

        //private static void AddWagons(List<int> wagons, List<string> input)
        //{
        //    int passangers = int.Parse(input[1]);
        //    wagons.Add(passangers);
        //}

        //private static void AddPassangers(List<int> wagons, int wagonCapacity, List<string> input)
        //{
        //    int passangers = int.Parse(input[0]);
        //    for (int i = 0; i < wagons.Count; i++)
        //    {
        //        if (wagons[i] + passangers <= wagonCapacity)
        //        {
        //            wagons[i] += passangers;
        //            break;
        //        }
        //    }
        //}
    }
}
//Exercise 1. Train

//You will receive a list of wagons(integers) on the first line.Every integer represents the number of passengers that
//are currently in each of the wagons. On the next line, you will get the max capacity of each wagon (a single
//integer). Until you receive &quot;end&quot; you will be given two types of input:

// Add {passengers} – add a wagon to the end with the given number of passengers.
// { passengers} - find an existing wagon to fit every passenger, starting from the first wagon.

//At the end print the final state of the train (each of the wagons, separated by a space).

//Example
//Input                   |      Output
//32 54 21 12 4 0 23      |      72 54 21 12 4 75 23 10 0
//75                      |
//Add 10                  |
//Add 0                   |
//30                      |
//10                      |
//75                      |
//end                     |
//---------------------------------------------------------                          
//0 0 0 10 2 4            |      10 10 10 10 10 10 10
//10                      |
//Add 10                  |
//10                      |
//10                      |
//10                      |
//8                       |
//6                       |
//end                     |