using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            RemoveNegativeNumbers(numbers);
            
            
        }
        static List<int> RemoveNegativeNumbers(List<int> numbers)
        {
            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
            }
            if (HasPositiveNumbers(positiveNumbers) == false)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", ReversePositions(positiveNumbers)));
            }
            return positiveNumbers;
        }
        static bool HasPositiveNumbers(List<int> positiveNumbers)
        {
            if (positiveNumbers.Count == 0)
            {
                return false;
            }
            return true;
        }
        static List<int> ReversePositions(List<int> positiveNumbers)
        {
            positiveNumbers.Reverse();
            return positiveNumbers;
            
        }
    }
}
