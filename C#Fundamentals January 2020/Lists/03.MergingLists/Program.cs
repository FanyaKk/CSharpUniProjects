using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", MargingList(firstList, secondList)));
        }
        static List<int> MargingList(List<int> firstList, List<int> secondList)
        {
            List<int> result = new List<int>();

            int longerList = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < longerList; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            return result;
        }
    }
}
