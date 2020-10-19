﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();


            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                counts[word]++;
            }
            foreach (var count in counts)
            {
                if(count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}
