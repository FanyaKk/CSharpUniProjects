using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder other = new StringBuilder();

            foreach (char symbol in str)
            {
                if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else
                {
                    other.Append(symbol);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
