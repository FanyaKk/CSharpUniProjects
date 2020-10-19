using System;

namespace _05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMen = int.Parse(Console.ReadLine());
            int numberOfWomen = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfMen; i++)
            {
                for (int j = 1; j <= numberOfWomen; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tables--;
                    if (tables <= 0)
                    {
                        return;
                    }
                }
            }
        }
    }
}
