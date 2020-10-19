using System;

namespace EvenDegreeOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());

            double result = 0;

            for (int i = 0; i <= degree; i++)
            {
                if (i % 2 == 0)
                {
                    result = Math.Pow(2, i);
                    Console.WriteLine(result);
                }
            }

            //ex.2
            //double current = 1;

            //for (int i = 0; i < degree; i += 2)
            //{
            //     Console.WriteLine(current);
            //     current *= 4;
            //}

            //double result = 1;

            //for (int i = 0; i < degree; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(result);
            //    }
            //    result *= 2;
            //}
        }
    }
}
