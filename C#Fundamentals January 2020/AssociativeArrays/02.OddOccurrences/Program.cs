using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)                 //version 2.0
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
            Dictionary<string, int> filteredWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!filteredWords.ContainsKey(word))
                {
                    filteredWords[word] = 0;
                }
                filteredWords[word]++;
            }
            foreach (var word in filteredWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }

        //static void Main(string[] args)               //version 1.0
        //{
        //    string[] words = Console.ReadLine().ToLower().Split().ToArray();
        //    Dictionary<string, int> counts = new Dictionary<string, int>();


        //    foreach (var word in words)
        //    {
        //        if (!counts.ContainsKey(word))
        //        {
        //            counts[word] = 0;
        //        }
        //        counts[word]++;
        //    }
        //    foreach (var count in counts)
        //    {
        //        if(count.Value % 2 != 0)
        //        {
        //            Console.Write($"{count.Key} ");
        //        }
        //    }
        //}
    }
}
//2. Odd Occurrences

//Write a program that extracts all elements from a given sequence of words that are present in it an odd number of
//times(case-insensitive).

// Words are given on a single line, space separated.
// Print the result elements in lowercase, in their order of appearance.

//Examples
//Input                            |     Output
//                                 |
//Java C# PHP PHP JAVA C java      |     java c# c
//3 5 5 hi pi HO Hi 5 ho 3 hi pi   |     5 hi
//a a A SQL xx a xx a A a XX c     |     a sql xx c