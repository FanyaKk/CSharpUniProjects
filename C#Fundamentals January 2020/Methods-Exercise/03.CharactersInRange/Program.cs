using System;
using System.Linq;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());

            PrintAsciiChar(firstLetter, lastLetter);

        }
        static void PrintAsciiChar(char firstSymbol, char lastSymbol)
        {
            int asciiStart = Math.Min(firstSymbol, lastSymbol);
            int asciiEnd = Math.Max(firstSymbol, lastSymbol);


            for (int asciiCode = asciiStart + 1; asciiCode < asciiEnd; asciiCode++)
            {
                char symbol = (char)asciiCode;
                Console.Write(symbol + " ");
            }

            //РЕШЕНИЕ С МАСИВ!!!
            //char[] symbol = new char[asciiEnd - asciiStart - 1];
            //for (int asciiCode = 0; asciiCode < symbol.Length; asciiCode++)
            //{
            //    int position = asciiCode + asciiStart + 1;
            //    symbol[asciiCode] = (char)position;
            //    
            //}
            //Console.WriteLine(string.Join(" ", symbol));
        }
    }
}
