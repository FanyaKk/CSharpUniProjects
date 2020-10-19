using System;

namespace _03.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char symbol = number[i];
                int currentSymbolToNum = int.Parse(symbol.ToString());

                if (currentSymbolToNum == 0)
                {
                    Console.Write("ZERO");
                }
                for (int j = 0; j < currentSymbolToNum; j++)
                {
                    Console.Write((char)(currentSymbolToNum + 33));
                }
                Console.WriteLine();
            }
        }
    }
}