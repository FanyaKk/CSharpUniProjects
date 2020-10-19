using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (var item in numbers)
            {
                if (!counts.ContainsKey(item))
                {
                    counts[item] = 0;
                }
                counts[item]++;
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
