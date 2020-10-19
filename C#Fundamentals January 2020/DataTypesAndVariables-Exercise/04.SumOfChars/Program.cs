using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int sumLetters = 0;

            for (int i = 0; i < inputCount; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sumLetters += letters;
            }
            Console.WriteLine($"The sum equals: {sumLetters}");
        }
    }
}
