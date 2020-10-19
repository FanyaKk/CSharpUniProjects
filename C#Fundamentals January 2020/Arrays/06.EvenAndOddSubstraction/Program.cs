﻿using System;
using System.Linq;

namespace _06.EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }
            int result = sumEven - sumOdd;
            //Console.WriteLine($"Even:{sumEven}");
            //Console.WriteLine($"Odd:{sumOdd}");
            Console.WriteLine(result);

        }
    }
}
