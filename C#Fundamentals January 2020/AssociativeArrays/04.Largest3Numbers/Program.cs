using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)                 //version 2.0
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(n => Console.Write($"{n} "));
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    int[] sorted = numbers.OrderByDescending(n => n).ToArray();

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.Write($"{sorted[i]} ");
        //        if (i + 1 == sorted.Length)
        //        {
        //            break;
        //        }
        //    }
        //}
    }
}
//4. Largest 3 Numbers

//Read a list of integers and print the largest 3 of them.If there are less than 3, print all of them.

//Examples
//Input             |    Output
//--------------------------------------
//10 30 15 20 50 5  |    50 30 20
//--------------------------------------
//20 30             |    30 20