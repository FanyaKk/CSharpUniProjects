using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int digit = number % 10;

            string englishName = string.Empty;

            if (digit == 1)
            {
                englishName = "one";
            }
            else if (digit == 2)
            {
                englishName = "two";
            }
            else if (digit == 3)
            {
                englishName = "three";
            }
            else if (digit == 4)
            {
                englishName = "four";
            }
            else if (digit == 5)
            {
                englishName = "five";
            }
            else if (digit == 6)
            {
                englishName = "six";
            }
            else if (digit == 7)
            {
                englishName = "seven";
            }
            else if (digit == 8)
            {
                englishName = "eight";
            }
            else if (digit == 9)
            {
                englishName = "nine";
            }
            else if (digit == 0)
            {
                englishName = "zero";
            }
            Console.WriteLine(englishName);
        }
    }
}
