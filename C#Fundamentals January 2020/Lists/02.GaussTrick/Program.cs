using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SumFirstLastNum(numbers);

        }
        static void SumFirstLastNum(List<int> numbers)
        {
            List<int> originalNumbers = new List<int>(numbers);

            for (int i = 0; i < originalNumbers.Count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
