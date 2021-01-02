using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)                 //version 2.0
        {
            List<int> numbers = Console.ReadLine()              
                .Split()
                .Select(int.Parse)
                .ToList();
            SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!sortedNumbers.ContainsKey(numbers[i]))
                {
                    sortedNumbers[numbers[i]] = 0;
                }
                sortedNumbers[numbers[i]]++;
            }
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        //    SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

        //    foreach (var item in numbers)
        //    {
        //        if (!counts.ContainsKey(item))
        //        {
        //            counts[item] = 0;
        //        }
        //        counts[item]++;
        //    }
        //    foreach (var item in counts)
        //    {
        //        Console.WriteLine($"{item.Key} -> {item.Value}");
        //    }
        //}
    }
}
//1. Count Real Numbers

//Read a list of integers and print them in ascending order, along with their number of occurrences.
//Examples
//Input         Output

//8 2 2 8 2     2 -> 3
//              8 -> 2

//1 5 1 3       1 -> 2
//              3 -> 1
//              5 -> 1

//-2 0 0 2      -2 -> 1
//              0 -> 2
//              2 -> 1