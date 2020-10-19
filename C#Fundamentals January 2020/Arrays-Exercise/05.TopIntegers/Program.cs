using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (temp <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += temp + " ";
                }
                //int maxNumber = Math.Max(array[i], array[array.Length - 1]);

            }
            Console.WriteLine(result);
        }
    }
}

