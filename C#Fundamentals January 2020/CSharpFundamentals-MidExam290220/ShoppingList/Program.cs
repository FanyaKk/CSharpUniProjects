using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] input = command.Split().ToArray();

                string item = input[1];

                if (input[0] == "Urgent")
                {
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Add(item);
                    }
                }
                else if (input[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                }
                else if (input[0] == "Correct")
                {
                    string oldItem = input[1];
                    string newItem = input[2];
                    if (shoppingList.Contains(oldItem))
                    {
                        int oldItemIndex = shoppingList.IndexOf(oldItem);
                        shoppingList[oldItemIndex] = newItem;
                    }
                }
                else if (input[0] == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
