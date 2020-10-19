using System;

namespace _11.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerFirstNumber = int.Parse(Console.ReadLine());
            int firstPlayerSecondNumber = int.Parse(Console.ReadLine());
            int secondPlayerFirstNumber = int.Parse(Console.ReadLine());
            int secondPlayerSecondNumber = int.Parse(Console.ReadLine());

            int firstPlayer = 0;
            int secondPlayer = 0;
            int shifts = 0;

            for (int k = firstPlayerFirstNumber; k <= 8; k++)
            {
                for (int l = 9; l >= firstPlayerSecondNumber; l--)
                {
                    for (int m = secondPlayerFirstNumber; m <= 8; m++)
                    {
                        for (int n = 9; n >= secondPlayerSecondNumber; n--)
                        {
                            if (k % 2 == 0 && l % 2 != 0 && m % 2 == 0 && n % 2 != 0)
                            {
                                firstPlayer = (k * 10) + l;
                                secondPlayer = (m * 10) + n;
                                if (firstPlayer != secondPlayer && shifts < 6)
                                {
                                    Console.WriteLine($"{k}{l} - {m}{n}");
                                    shifts++;
                                }
                                else if (shifts < 6)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                //if (shifts == 6)
                                //{
                                //    return;
                                //}
                            }
                        }
                    }
                }
            }
        }
    }
}
