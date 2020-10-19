using System;
using System.Collections.Generic;
using System.Linq;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split().ToList();

            while(true)
            {
                string command = Console.ReadLine();
                string[] input = command.Split().ToArray();

                if(input[0] == "Join")
                {
                    string joinFrogName = input[1];
                    frogNames.Add(joinFrogName);
                }
                else if (input[0] == "Jump")
                {
                    int index = int.Parse(input[2]);
                    if (index >= 0 && index < frogNames.Count)
                    {
                        string frogName = input[1];
                        frogNames.Insert(index, frogName);
                    }
                }
                else if (input[0] == "Dive")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index < frogNames.Count)
                    {
                        frogNames.RemoveAt(index);
                    }
                }
                else if (input[0] == "First")
                {
                    int count = int.Parse(input[1]);
                    if (count >= frogNames.Count)
                    {
                        Console.WriteLine(string.Join(" ", frogNames));
                    }
                    else
                    {
                        List<string> firstCount = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            firstCount.Add(frogNames[i]);
                        }
                        Console.WriteLine(string.Join(" ", firstCount));
                    }
                }
                else if (input[0] == "Last")
                {
                    int count = int.Parse(input[1]);
                    if (count >= frogNames.Count)
                    {
                        Console.WriteLine(string.Join(" ", frogNames));
                    }
                    else
                    {
                        List<string> lastCount = new List<string>();
                        int startIndex = frogNames.Count - count;
                        for (int i = startIndex; i < frogNames.Count; i++)
                        {
                            lastCount.Add(frogNames[i]);   
                        }
                        Console.WriteLine(string.Join(" ", lastCount));
                    }
                }
                else if (input[0] == "Print")
                {
                    if (input[1] == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        break;
                    }
                    else if(input[1] == "Reversed")
                    {
                        frogNames.Reverse();
                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        break;
                    }
                }
            }
        }
    }
}
