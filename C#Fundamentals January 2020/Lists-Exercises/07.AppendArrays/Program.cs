using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.AddRange(numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }
            
            Console.WriteLine(string.Join(" ", result));


            //List<string> arrays = Console.ReadLine().Split('|').ToList();

            //List<string> result = new List<string>(arrays.Count);

            //for (int i = arrays.Count - 1; i >= 0; i--)
            //{
            //    string[] positions = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    for (int j = 0; j < positions.Length; j++)
            //    {
            //        result.Add(positions[j]);
            //    }
            //}
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
