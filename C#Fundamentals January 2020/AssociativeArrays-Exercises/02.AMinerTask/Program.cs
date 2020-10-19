using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(command))
                {
                    resources[command] = 0;
                }
                resources[command] += quantity;
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
