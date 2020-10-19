using System;

namespace _07.SafePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int maxGeneratedPass = int.Parse(Console.ReadLine());
            
            int firstSymbol = 35;
            int secondSymbol = 64;


            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    Console.Write($"{(char)firstSymbol}{(char)secondSymbol}{k}{l}{(char)secondSymbol}{(char)firstSymbol}|");

                    maxGeneratedPass--;
                    if (maxGeneratedPass < 1)
                    {
                        return;
                    }

                    if (firstSymbol == 55)
                    {
                        firstSymbol = 35;
                    }
                    if (secondSymbol == 96)
                    {
                        secondSymbol = 64;
                    }
                    firstSymbol++;
                    secondSymbol++;
                }
            }
        }
    }
}
