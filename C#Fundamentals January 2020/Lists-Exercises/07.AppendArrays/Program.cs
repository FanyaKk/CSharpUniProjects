using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] srgs)             //version 2.0
        {
            List<string> result = new List<string>();

            List<string> input = Console.ReadLine()
                .Split("|")
                .ToList();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                result.AddRange(input[i].ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }
            Console.WriteLine(string.Join(" ", result));

        }
        //static void Main(string[] args)               //version 1.0 & 1.1
        //{
        //    List<string> numbers = Console.ReadLine().Split('|').ToList();

        //    numbers.Reverse();
        //    List<string> result = new List<string>();
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        result.AddRange(numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
        //    }

        //    Console.WriteLine(string.Join(" ", result));


        //    List<string> arrays = Console.ReadLine().Split('|').ToList();

        //    List<string> result = new List<string>(arrays.Count);

        //    for (int i = arrays.Count - 1; i >= 0; i--)
        //    {
        //        string[] positions = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //        for (int j = 0; j < positions.Length; j++)
        //        {
        //            result.Add(positions[j]);
        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", result));
        //}
    }
}
//Exercise 7. Append Arrays

//Write a program to append several arrays of numbers.

// Arrays are separated by "|".
// Values are separated by spaces(" ", one or several).
// Order the arrays from the last to the first, and their values from left to right.

//Examples

//Input                 |    Output
//--------------------------------------------
//1 2 3 |4 5 6 | 7 8    |    7 8 4 5 6 1 2 3
//7 | 4 5|1 0| 2 5 |3   |    3 2 5 1 0 4 5 7
//1| 4 5 6 7 | 8 9      |    8 9 4 5 6 7 1