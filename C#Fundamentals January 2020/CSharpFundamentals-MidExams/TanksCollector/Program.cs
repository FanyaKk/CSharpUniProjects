using System;
using System.Collections.Generic;
using System.Linq;

namespace TanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanksCollection = Console.ReadLine().Split(", ").ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i< numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(", ").ToArray();

                if(command[0] == "Add")
                {
                    string tankName = command[1];
                    Add(tanksCollection, tankName);
                }
                else if (command[0] == "Remove")
                {
                    string tankName = command[1];
                    Remove(tanksCollection, tankName);
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    RemoveAt(tanksCollection, index);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string tankName = command[2];
                    Insert(tanksCollection, index, tankName);   
                }
            }
            Console.WriteLine(string.Join(", ", tanksCollection));
        }


        static void Add(List<string> tanksCollection, string tankName)
        {
            if (tanksCollection.Contains(tankName))
            {
                Console.WriteLine("Tank is already bought");
            }
            else
            {
                Console.WriteLine("Tank successfully bought");
                tanksCollection.Add(tankName);
            }
        }
        static void Remove(List<string> tanksCollection, string tankName)
        {
            if (tanksCollection.Contains(tankName))
            {
                Console.WriteLine("Tank successfully sold");
                tanksCollection.Remove(tankName);
            }
            else
            {
                Console.WriteLine("Tank not found");
            }
        }
        static void RemoveAt(List<string> tanksCollection, int index)
        {
            if (index >= 0 && index < tanksCollection.Count)
            {
                tanksCollection.RemoveAt(index);
                Console.WriteLine("Tank successfully sold");
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }
        static void Insert(List<string> tanksCollection, int index, string tankName)
        {
            if (index >= 0 & index < tanksCollection.Count)
            {
                if (tanksCollection.Contains(tankName))
                {
                    Console.WriteLine("Tank is already bought");
                }
                else
                {
                    Console.WriteLine("Tank successfully bought");
                    tanksCollection.Insert(index, tankName);
                }
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}
