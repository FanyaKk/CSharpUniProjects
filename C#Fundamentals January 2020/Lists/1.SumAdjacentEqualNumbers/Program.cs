using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)         //version 2.0
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                //int currNumber = numbers[i];
                //int nextNumber = numbers[i + 1];

                if (numbers[i] == numbers[i+1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        //static void Main(string[] args)       //version 1.0
        //{
        //    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        //    for (int i = 0; i < numbers.Count - 1; i++)
        //    {
        //        if(numbers[i] == numbers[i + 1])
        //        {
        //            numbers[i] += numbers[i + 1];
        //            numbers.RemoveAt(i + 1);
        //            i = -1;
        //        }

        //    }
        //    Console.WriteLine(string.Join(" ", numbers));
        //}




        //static void Main(string[] args)
        //{
        //    int[] arrayX = new int[3] { 1, 2, 3 };
        //    PrintAfter10Years(arrayX);
        //    Console.WriteLine(arrayX[0]);

        //}
        //static void PrintAfter10Years(int[] number)
        //{
        //    number[0] = 55;
        //}
    }
}
//Exercise 1. Sum Adjacent Equal Numbers
//
//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//
//-> After two numbers are summed, the obtained result could be equal to some of its neighbors and should be
//summed as well (see the examples below).
//
//-> Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).
//
//Examples
//Input Output Explanation
//3 3 6 1        |   12 1     |   3 3 6 1 -> 6 6 1 -> 12 1
//8 2 2 4 8 16   |   16 8 16  |   8 2 2 4 8 16 -> 8 4 4 8 16 -> 8 8 8 16 -> 16 8 16
//5 4 2 1 1 4    |   5 8 4    |   5 4 2 1 1 4 -> 5 4 2 2 4 -> 5 4 4 4 -> 5 8 4