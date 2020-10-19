using System;

namespace _01.UniquePINCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberLimit = int.Parse(Console.ReadLine());
            int secondNumberLimit = int.Parse(Console.ReadLine());
            int thirdNumberLimit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumberLimit; i++)
            {
                for (int j = 2; j <= secondNumberLimit; j++)
                {
                    for (int k = 1; k <= thirdNumberLimit; k++)
                    {
                        if ((i % 2 == 0) && (k % 2 == 0) && (j == 2 || j == 3 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
