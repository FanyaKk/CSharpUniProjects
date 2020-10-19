using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currString = input[i];

                char firstLetter = currString[0];
                bool isUpper = Char.IsUpper(firstLetter);

                char secondLetter = currString[currString.Length - 1];
                bool isLower = Char.IsLower(secondLetter);

                int substringLength = currString.Length - 2;
                double number = double.Parse(currString.Substring(1, substringLength));

                int letterPosition = 0;
                double currResult = 0;


                if (isUpper)
                {
                    letterPosition = firstLetter - 64;
                    currResult = number / letterPosition;
                }
                else
                {
                    letterPosition = firstLetter - 96;
                    currResult = number * letterPosition;
                }
                if (isLower)
                {
                    letterPosition = secondLetter - 96;
                    currResult += letterPosition;
                }
                else
                {
                    letterPosition = secondLetter - 64;
                    currResult -= letterPosition;
                }
                result += currResult;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
