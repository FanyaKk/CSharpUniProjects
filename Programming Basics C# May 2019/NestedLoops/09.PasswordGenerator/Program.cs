using System;

namespace _09.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int letterNumber = int.Parse(Console.ReadLine());
            int letter = letterNumber + 97;

            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j < number; j++)
                {
                    for (int k = 97; k < letter; k++)
                    {
                        for (int l = 97; l < letter; l++)
                        {
                            for (int m = 1; m <= number; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
