using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string containwords = Console.ReadLine();

            int index = containwords.IndexOf(word);

            while (index != -1)
            {
                containwords = containwords.Remove(index, word.Length);
                index = containwords.IndexOf(word);
            }
            Console.WriteLine(containwords);
        }
    }
}
