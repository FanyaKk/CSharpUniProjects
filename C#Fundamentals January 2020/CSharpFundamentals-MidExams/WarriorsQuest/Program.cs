using System;
using System.Collections.Generic;
using System.Linq;

namespace WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deciphered = Console.ReadLine().Split().ToList();

            string command = "";

            while ((command = Console.ReadLine())!= "For Azeroth")
            {
                string[] input = command.Split().ToArray();

                if (input[0] == "GladiatorStance")
                {
                    Console.WriteLine(deciphered.ToString().ToUpper());
                }
                else if (input[0] == "DefensiveStance")
                {
                    Console.WriteLine(deciphered.ToString().ToLower());
                }
                else if (input[0] == "Dispel")
                {
                    int index = int.Parse(input[1]);
                    char letter = char.Parse(input[2]);
                    if (index < 0 || index >= deciphered.Count)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        for (int i = 0; i < deciphered.Count; i++)
                        {
                            if (i == index)
                            {
                                deciphered[i] = letter.ToString();
                            }
                        }
                    }
                }
                else if (input[0] == "Target")
                {
                    if (input[1] == "Change")
                    {
                        string substring = input[2];
                        string secondsubstring = input[3];

                    }
                    else if (input[1] == "Remove")
                    {

                    }
                }
                
            }
        }
    }
}
