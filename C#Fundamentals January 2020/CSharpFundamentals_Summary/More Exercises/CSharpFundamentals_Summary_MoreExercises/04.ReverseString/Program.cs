﻿using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reverseInput = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
                reverseInput += input[i];
            }
            Console.WriteLine(reverseInput);
        }
    }
}
