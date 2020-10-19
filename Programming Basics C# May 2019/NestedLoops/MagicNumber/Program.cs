using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int m1 = 1; m1 <= 9; m1++)
            {
                for (int m2 = 1; m2 <= 9; m2++)
                {
                    for (int m3 = 1; m3 <= 9; m3++)
                    {
                        for (int m4 = 1; m4 <= 9; m4++)
                        {
                            for (int m5 = 1; m5 <= 9; m5++)
                            {
                                for (int m6 = 1; m6 <= 9; m6++)
                                {
                                    if (m1 * m2 * m3 * m4 * m5 * m6 == magicNumber)
                                    {
                                        Console.Write($"{m1}{m2}{m3}{m4}{m5}{m6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
