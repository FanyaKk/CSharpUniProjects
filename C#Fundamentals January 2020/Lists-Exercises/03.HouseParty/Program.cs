using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string name = command[0];

                if(command[2] == "not")
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (!guestList.Contains(name))
                    {
                        guestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", guestList));
        }
    }
}
