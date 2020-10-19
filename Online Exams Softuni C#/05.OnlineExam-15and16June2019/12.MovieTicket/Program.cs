using System;

namespace _12.MovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int symbolOne = a1; symbolOne <= a2 - 1; symbolOne++)
            {
                if (symbolOne %2 == 0)
                {
                    continue;
                }
                char charSymbolOne = Convert.ToChar(symbolOne);
                for (int symbolTwo = 1; symbolTwo <= n - 1; symbolTwo++)
                {
                    for (int symbolThree = 1; symbolThree <= (n / 2) - 1; symbolThree++)
                    {
                        int symbolFour = symbolOne;
                        int sum = symbolTwo + symbolThree + symbolFour;
                        if (sum %2 != 0)
                        {
                            Console.WriteLine($"{charSymbolOne}-{symbolTwo}{symbolThree}{symbolFour}");
                        }
                    }
                }
            }
        }
    }
}
