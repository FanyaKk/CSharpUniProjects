using System;
using System.Linq;

namespace _04.ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().Reverse().ToArray();

            //Console.WriteLine(string.Join(" ", Console.ReadLine().Reverse().ToArray()));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
