using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int asciiSum = 0;

            int asciiStartValue = firstChar;
            int asciiEndValue = secondChar;

            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                if (value > asciiStartValue && value < asciiEndValue)
                {
                    asciiSum += value;
                }    
            }
            Console.WriteLine(asciiSum);
        }
    }
}
