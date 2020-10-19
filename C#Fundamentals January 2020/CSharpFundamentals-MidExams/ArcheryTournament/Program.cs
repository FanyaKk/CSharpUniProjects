using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            string command = "";
            int iskrenPoints = 0;

            while((command=Console.ReadLine())!="Game over")
            {
                string[] input = command.Split("@").ToArray();
                if (input[0] == "Reverse")
                {
                    target.Reverse();
                    continue;
                }
                int startIndex = int.Parse(input[1]);
                int length = int.Parse(input[2]);
                int count = length % target.Count;
                bool hasShoot = false;

                if (startIndex >= 0 && startIndex < target.Count)
                {
                    if (input[0]=="Shoot Left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            startIndex--;
                            if (startIndex == -1)
                            {
                                startIndex = target.Count - 1;
                            }
                        }
                        hasShoot = true;
                    }
                    else if (input[0] == "Shoot Right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            startIndex++;
                            if (startIndex == target.Count)
                            {
                                startIndex = 0;
                            }
                        }
                        hasShoot = true;
                    }
                    if (hasShoot && target[startIndex] < 5)
                    {
                        iskrenPoints += target[startIndex];
                        target[startIndex] = 0;
                    }
                    else if(hasShoot)
                    {
                        iskrenPoints += 5;
                        target[startIndex] -= 5;
                    }
                }
            }
            Console.WriteLine(string.Join(" - ", target));
            Console.WriteLine($"Iskren finished the archery tournament with {iskrenPoints} points!");
            //    List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            //    string command = "";
            //    int iskrenPoints = 0;

            //    while ((command = Console.ReadLine()) != "Game over")
            //    {
            //        string[] input = command.Split("@").ToArray();

            //        if (input[0] == "Reverse")
            //        {
            //            targets.Reverse();
            //            continue;
            //        }
            //        int startIndex = int.Parse(input[1]);
            //        int length = int.Parse(input[2]);
            //        int endIndex = targets.Count - 1;
            //        int traversing = length % targets.Count;
            //        int shootPosition = 0;

            //        if (startIndex < 0 || startIndex > targets.Count - 1)
            //        {
            //            continue;
            //        }
            //        else if (input[0] == "Shoot Left")
            //        {
            //            if (startIndex - traversing < 0)
            //            {
            //                int currStartIndex = traversing - startIndex;
            //                shootPosition = targets.Count - currStartIndex; // 30 15 17 19 20
            //                //WinPoints(targets, transitions, startIndex, iskrenPoints);
            //                if (targets[shootPosition] < 5)
            //                {
            //                    iskrenPoints += targets[shootPosition];
            //                    targets[shootPosition] = 0;
            //                }
            //                else
            //                {
            //                    iskrenPoints += 5;
            //                    targets[shootPosition] -= 5;
            //                }
            //            }
            //            else
            //            {
            //                shootPosition = startIndex - traversing;
            //                //WinPoints(targets, shootPosition, startIndex, iskrenPoints);
            //                if (targets[shootPosition] < 5)
            //                {
            //                    iskrenPoints += targets[shootPosition];
            //                    targets[shootPosition] = 0;
            //                }
            //                else
            //                {
            //                    iskrenPoints += 5;
            //                    targets[shootPosition] -= 5;
            //                }
            //            }
            //        }
            //        else if(input[0]== "Shoot Right")
            //        {
            //            for (int i = 0; i < traversing; i++)
            //            {
            //                startIndex--;
            //                if (startIndex == -1)
            //                {
            //                    startIndex = targets.Count - 1;
            //                }
            //            }
            //            if (startIndex + traversing >= targets.Count)
            //            {
            //                //int currStartIndex = traversing + startIndex;
            //                //int currStartIndex = startIndex;

            //                //shootPosition = currStartIndex;
            //                //shootPosition = currStartIndex - targets.Count;
            //                if (targets[shootPosition] < 5)
            //                {
            //                    iskrenPoints += targets[shootPosition];
            //                    targets[shootPosition] = 0;
            //                }
            //                else
            //                {
            //                    iskrenPoints += 5;
            //                    targets[shootPosition] -= 5;
            //                }
            //            }
            //            else
            //            {
            //                shootPosition = startIndex + traversing;
            //                if (targets[shootPosition] < 5)
            //                {
            //                    iskrenPoints += targets[shootPosition];
            //                    targets[shootPosition] = 0;
            //                }
            //                else
            //                {
            //                    iskrenPoints += 5;
            //                    targets[shootPosition] -= 5;
            //                }
            //            }
            //        }
            //    }
            //    if (command == "Game over")
            //    {
            //        Console.WriteLine(string.Join(" - ", targets));
            //        Console.WriteLine($"Iskren finished the archery tournament with {iskrenPoints} points!");
            //    }
            //}
            //static void WinPoints(List<int> targets, int transitions, int startIndex, int winPoints)
            //{
            //    int currStartIndex = transitions - startIndex;
            //    int shootPosition = targets.Count - currStartIndex;
            //    if (targets[shootPosition] < 5)
            //    {
            //        winPoints += targets[shootPosition];
            //        targets[shootPosition] = 0;
            //    }
            //    else
            //    {
            //        winPoints += 5;
            //        targets[shootPosition] -= 5;
            //    }
        }
    }
}
