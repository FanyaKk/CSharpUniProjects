﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)         //version 2.0
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(firstNumbers.Count, secondNumbers.Count); i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));

        
        }
        //static void Main(string[] args)       //version 1.0
        //{
        //    List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    Console.WriteLine(string.Join(" ", MargingList(firstList, secondList)));
        //}
        //static List<int> MargingList(List<int> firstList, List<int> secondList)
        //{
        //    List<int> result = new List<int>();

        //    int longerList = Math.Max(firstList.Count, secondList.Count);

        //    for (int i = 0; i < longerList; i++)
        //    {
        //        if (i < firstList.Count)
        //        {
        //            result.Add(firstList[i]);
        //        }
        //        if (i < secondList.Count)
        //        {
        //            result.Add(secondList[i]);
        //        }
        //    }
        //    return result;

    }
}
//Exercise 3.Merging Lists
//You are going to receive two lists with numbers. Create a result list, which contains the numbers from both of the
//lists.The first element should be from the first list, the second from the second list and so on.If the length of the
//two lists are not equal, just add the remaining elements at the end of the list.
//
//Example
//Input                                     Output
//3 5 2 43 12 3 54 10 23 76 5 34 2 4 12     3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
//76 5 34 2 4 12 3 5 2 43 12 3 54 10 23     76 3 5 5 34 2 2 43 4 12 12 3 54 10 23

//Hint
// Read the two lists
// Create a result list
// Start looping through them until you reach the end of the smallest one
// Finally add the remaining elements(if there are any) to the end of the list