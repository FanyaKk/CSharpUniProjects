using System;
using System.Linq;
using System.Text;

namespace WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skills = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "For Azeroth")
            {
                string[] command = input.Split();

                if (command[0] == "GladiatorStance")
                {
                    skills = skills.ToUpper();
                    Console.WriteLine(skills);
                }
                else if (command[0] == "DefensiveStance")
                {
                    skills = skills.ToLower();
                    Console.WriteLine(skills);
                }
                else if (command[0] == "Dispel")
                {
                    int index = int.Parse(command[1]);
                    string letter = command[2];
                    if (index >= 0 && index < skills.Length)
                    {
                        skills = skills.Remove(index, 1);
                        skills = skills.Insert(index, letter);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }

                }
                else if (command[0] == "Target" && command[1] == "Change")
                {
                    string substring = command[2];
                    string secondSubstring = command[3];
                    if (skills.Contains(substring))
                    {
                        skills = skills.Replace(substring, secondSubstring);
                        Console.WriteLine(skills);
                    }
                }
                else if (command[0] == "Target" && command[1] == "Remove")
                {
                    string substring = command[2];
                    if (skills.Contains(substring))
                    {
                        int startIndex = skills.IndexOf(substring);
                        skills = skills.Remove(startIndex, substring.Length);
                        Console.WriteLine(skills);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
