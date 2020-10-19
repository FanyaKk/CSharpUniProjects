using System;

namespace _12.TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int winCombination = int.Parse(Console.ReadLine());

            char iSymbol = ' ';
            char kSymbol = ' ';
            char lSymbol = ' ';

            int combinationsCount = 0;
            int price = 0;

            for (int i = 66; i <= 90; i++)
            {
                for (int k = 102; k >= 97; k--)
                {
                    for (int l = 65; l <= 67; l++)
                    {
                        for (int m = 1; m <= 10; m++)
                        {
                            for (int n = 10; n >= 1; n--)
                            {
                                if (i % 2 == 0)
                                {
                                    combinationsCount++;
                                }
                                if (combinationsCount == winCombination)
                                {
                                    price = i + k + l + m + n;
                                    iSymbol = Convert.ToChar(i);
                                    kSymbol = Convert.ToChar(k);
                                    lSymbol = Convert.ToChar(l);
                                    Console.WriteLine($"Ticket combination: {iSymbol}{kSymbol}{lSymbol}{m}{n}");
                                    Console.WriteLine($"Prize: {price} lv.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
