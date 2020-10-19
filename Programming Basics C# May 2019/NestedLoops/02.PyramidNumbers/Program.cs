using System;

namespace _02.PyramidNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int current = 1;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (current > number)
                    {
                        return;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            }
        }
    }
}
