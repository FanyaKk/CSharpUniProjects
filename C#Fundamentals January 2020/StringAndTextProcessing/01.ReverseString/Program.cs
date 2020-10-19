using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                char[] word = command.ToCharArray();
                char[] reverseWord = word.Reverse().ToArray();

                Console.WriteLine($"{string.Join("", word)} = {string.Join("", reverseWord)}");
            }
        }
    }
}
