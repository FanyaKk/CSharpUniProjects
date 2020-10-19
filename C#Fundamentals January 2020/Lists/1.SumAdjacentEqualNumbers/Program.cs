using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }




        //static void Main(string[] args)
        //{
        //    int[] arrayX = new int[3] { 1, 2, 3 };
        //    PrintAfter10Years(arrayX);
        //    Console.WriteLine(arrayX[0]);

        //}
        //static void PrintAfter10Years(int[] number)
        //{
        //    number[0] = 55;
        //}
    }
}
