using System;

namespace _06.MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleCharacter(text);
        }
        static void PrintMiddleCharacter(string text)
        {
            char firstChar = ' ';
            char secondChar = ' ';
            char middleSymbol = ' ';

            if (text.Length % 2 == 0)
            {
                firstChar = text[text.Length / 2 - 1];
                secondChar = text[text.Length / 2];
                Console.WriteLine($"{firstChar}{secondChar}");
            }
            else
            {
                middleSymbol = text[text.Length / 2];
                Console.WriteLine(middleSymbol);
            }
        }
    }
}
