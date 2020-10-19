using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberOfLines];
            int[] secondArray = new int[numberOfLines];

            for (int i = 1; i <= numberOfLines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j == 0)
                        {
                            firstArray[i - 1] += numbers[j];
                        }
                        else
                        {
                            secondArray[i - 1] += numbers[j];
                        }
                    }
                    else
                    {
                        if (j == 1)
                        {
                            firstArray[i - 1] += numbers[j];
                        }
                        else
                        {
                            secondArray[i - 1] += numbers[j];
                        }
                    }
                }                
            }
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.Write($"{firstArray[i]} ");                
            }
            Console.WriteLine();
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.Write($"{secondArray[i]} ");
            }
        }
    }
}
