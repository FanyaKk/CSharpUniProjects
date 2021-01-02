using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)             // version 2.0  better outprint method
        {
            string input = Console.ReadLine();
            int count = 1;
            string resource = string.Empty;
            int quantity = 0;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                if (count % 2 != 0)
                {
                    resource = input;
                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }  
                }
                else
                {
                    quantity = int.Parse(input);
                    resources[resource] += quantity;
                }
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine(string.Join(Environment.NewLine, resources.Select(x=>$"{x.Key} -> {x.Value}")));
        }
        //static void Main(string[] args)               //version 1.0 better logic
        //{
        //    string command = "";

        //    Dictionary<string, int> resources = new Dictionary<string, int>();

        //    while ((command = Console.ReadLine()) != "stop")
        //    {
        //        int quantity = int.Parse(Console.ReadLine());

        //        if (!resources.ContainsKey(command))
        //        {
        //            resources[command] = 0;
        //        }
        //        resources[command] += quantity;
        //    }
        //    foreach (var resource in resources)
        //    {
        //        Console.WriteLine($"{resource.Key} -> {resource.Value}");
        //    }
        //}
    }
}
//2. A Miner Task

//You will be given a sequence of strings, each on a new line.Every odd line on the console is representing a resource
//(e.g.Gold, Silver, Copper, and so on) and every even - quantity.Your task is to collect the resources and print them
//each on a new line.

//Print the resources and their quantities in the following format:
//{resource} –> {quantity}
//The quantities will be in the range[1 … 2 000 000 000]

//Examples

//Input                 Output

//Gold                  Gold -> 155
//155                   Silver -> 10
//Silver                Copper -> 17
//10
//Copper
//17
//stop
//-------------------------------------------
//gold                  gold -> 170
//155                   silver -> 10
//silver                copper -> 17
//10
//copper
//17
//gold
//15
//stop
