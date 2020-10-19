using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}
