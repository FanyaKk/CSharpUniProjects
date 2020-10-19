using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!counts.ContainsKey(word[i]))
                    {
                        counts[word[i]] = 0;
                    }
                    counts[word[i]]++;
                }  
            }
            foreach (var letter in counts)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
