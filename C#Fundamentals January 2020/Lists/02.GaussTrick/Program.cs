using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)         //version 2.0
        {
            List<int> result = new List<int>();
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(sum);
            }
            if (numbers.Count%2 == 1)
            {
                int index = numbers.Count / 2;
                result.Insert(index, numbers[index]);
            }
            Console.WriteLine(string.Join(" ", result));
        }

        //static void Main(string[] args)       //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    SumFirstLastNum(numbers);

        //}
        //static void SumFirstLastNum(List<int> numbers)
        //{
        //    List<int> originalNumbers = new List<int>(numbers);

        //    for (int i = 0; i < originalNumbers.Count / 2; i++)
        //    {
        //        numbers[i] += numbers[numbers.Count - 1];
        //        numbers.RemoveAt(numbers.Count - 1);
        //    }
        //    Console.WriteLine(string.Join(" ", numbers));
        //}
    }
}
//Exercise 2. Gauss' Trick
//
//Write a program that sums all of the numbers in a list in the following order:
//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
//
//Example
//Input      |   Output
//1 2 3 4 5  |   6 6 3
//1 2 3 4    |   5 5