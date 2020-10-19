using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendlistMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine().Split(", ").ToList();

            string command = "";
            int blacklistedCount = 0;
            int lostCount = 0;

            while ((command = Console.ReadLine()) != "Report")
            {
                string[] input = command.Split().ToArray();

                if(input[0] == "Blacklist")
                {
                    string name = input[1];
                    if (BlacklistedName(friendList, name))
                    {
                        blacklistedCount++;
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }    
                }
                else if (input[0] == "Error")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index < friendList.Count)
                    {
                        if (Error(friendList, index))
                        {
                            Error(friendList, index);
                            lostCount++;
                        }
                    }
                }
                else if (input[0] == "Change")
                {
                    int index = int.Parse(input[1]);
                    string newName = input[2];
                    ChangeName(friendList, index, newName);
                }
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", friendList));
        }

        //Method to blacklisted names in list
        static bool BlacklistedName(List<string> friendList, string name)
        {
            if (friendList.Contains(name))
            {
                friendList[friendList.IndexOf(name)] = "Blacklisted";
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to mark names as "Lost"
        static bool Error(List<string> friendList, int index)
        {
            string name = friendList[index];
            if (name != "Blacklisted" && name != "Lost")
            {
                friendList[index] = "Lost";
                Console.WriteLine($"{name} was lost due to an error.");
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method who change names in list
        static void ChangeName(List<string> friendList, int index, string newName)
        {
            string currentName = friendList[index];
            if (index >= 0 && index < friendList.Count)
            {
                friendList[index] = newName;
                Console.WriteLine($"{currentName} changed his username to {newName}.");
            }
        }
    }
}
