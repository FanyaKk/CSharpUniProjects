using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string command = "";

            while((command = Console.ReadLine())!= "Craft!")
            {
                string[] input = command.Split(" - ").ToArray();
                string item = input[1];

                if(input[0]== "Collect")
                {
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (input[0] == "Drop")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (input[0] == "Combine Items")
                {
                    string[] twoItems = input[1].Split(":").ToArray();
                    string oldItem = twoItems[0];
                    string newItem = twoItems[1];
                    if (journal.Contains(oldItem))
                    {
                        int oldItemIndex = journal.IndexOf(oldItem);
                        int newItemIndex = oldItemIndex + 1;
                        journal.Insert(newItemIndex, newItem);
                    }
                }
                else if (input[0] == "Renew")
                {
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
