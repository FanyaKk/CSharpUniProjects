using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();

            PrintVowel(inputText);

        }
        static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'o' || letter == 'i' || letter == 'e' || letter == 'u' || letter == 'y';
        }
        static void PrintVowel(string text)
        {
            int vowelCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (isVowel(symbol))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
