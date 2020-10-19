using System;
using System.Linq;
using System.Text;

namespace _06.ReplacingRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();

            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars.Length - 1 != i)
                {
                    if (chars[i] != chars[i + 1])
                    {
                        symbols.Append(chars[i]);
                    }
                }
                else
                {
                    symbols.Append(chars[i]);
                }
            }
            Console.WriteLine(symbols);
        }
    }
}
