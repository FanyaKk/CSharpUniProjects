using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine().ToUpper();
            string secondWord = Console.ReadLine().ToUpper();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
