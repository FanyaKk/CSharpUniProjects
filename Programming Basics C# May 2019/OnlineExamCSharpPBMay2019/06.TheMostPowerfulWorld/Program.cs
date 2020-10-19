using System;

namespace _06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            bool hasVowel = false;
            double totalValue = 0;

            double mostPowerfullValue = 0;
            string mostPowerfullWord = "";

            while (word != "End of words")
            {
                double value = 0;
                int wordLength = word.Length;

                for (int i = 0; i < wordLength; i++)
                {
                    value += word[i];
                    char symbol = word[i];
                    //int currentSymbolToNum = int.Parse(symbol.ToString());
                    if (i == 0)
                    {
                        symbol = char.ToLower(symbol);
                        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
                        {
                            hasVowel = true;
                        }
                    }
                }
                if (hasVowel == true)
                {
                    totalValue = value * wordLength;
                }
                else
                {
                    totalValue = Math.Floor(value / wordLength);
                }
                if (mostPowerfullValue < totalValue)
                {
                    mostPowerfullWord = word;
                    mostPowerfullValue = totalValue;
                }

                word = Console.ReadLine();
                hasVowel = false;
            }
            Console.WriteLine($"The most powerful word is {mostPowerfullWord} - {mostPowerfullValue}");
        }
    }
}
