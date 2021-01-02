using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(n => n < 0);
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.Remove(numbers[i]);
            //        i -= 1;
            //    }
            //}
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }

            
        }
        //static void Main(string[] args)           //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    RemoveNegativeNumbers(numbers);

        //}
        //static List<int> RemoveNegativeNumbers(List<int> numbers)
        //{
        //    List<int> positiveNumbers = new List<int>();

        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] > 0)
        //        {
        //            positiveNumbers.Add(numbers[i]);
        //        }
        //    }
        //    if (HasPositiveNumbers(positiveNumbers) == false)
        //    {
        //        Console.WriteLine("empty");
        //    }
        //    else
        //    {
        //        Console.WriteLine(string.Join(" ", ReversePositions(positiveNumbers)));
        //    }
        //    return positiveNumbers;
        //}
        //static bool HasPositiveNumbers(List<int> positiveNumbers)
        //{
        //    if (positiveNumbers.Count == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        //static List<int> ReversePositions(List<int> positiveNumbers)
        //{
        //    positiveNumbers.Reverse();
        //    return positiveNumbers;

        //}
    }
}
//Exersice 5. Remove Negatives and Reverse
//Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. In
//case there are no elements left in the list, print "empty".
//
//Examples
//Input               |  Output
//10 - 5 7 9 - 33 50  |  50 9 7 10
//7 - 2 - 10 1        |  1 7
//  - 1 - 2 - 3       |  empty