using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sumLetter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    sumLetter += 1;
                }
                if (word[i] == 'e')
                {
                    sumLetter += 2;
                }
                if (word[i] == 'i')
                {
                    sumLetter += 3;
                }
                if (word[i] == 'o')
                {
                    sumLetter += 4;
                }
                if (word[i] == 'u')
                {
                    sumLetter += 5;
                }
            }
            Console.WriteLine(sumLetter);
        }
    }
}