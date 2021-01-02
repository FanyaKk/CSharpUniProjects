﻿using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            if (number > 1000)
            {
                throw new Exception("The number cannot be more than 1000");
            }
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
