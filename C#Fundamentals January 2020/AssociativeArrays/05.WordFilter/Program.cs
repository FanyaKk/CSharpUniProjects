using System;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    string[] words = Console.ReadLine()
        //        .Split()
        //        .Where(x => x.Length % 2 == 0)
        //        .ToArray();

        //    Console.WriteLine(string.Join("\n", words));
        //}
    }
}
//5. Word Filter

//Read an array of strings and take only words, whose length is even.Print each word on a new line.

//Examples

//Input                        |     Output
//----------------------------------------------------------
//kiwi orange banana apple     |     kiwi orange banana
//----------------------------------------------------------
//pizza cake pasta chips       |     cake