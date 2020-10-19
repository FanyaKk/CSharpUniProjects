using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            //while (true)
            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNumberIndex = numbers.IndexOf(bombNumber);
                if (bombNumberIndex < 0 || bombNumberIndex > numbers.Count - 1)
                {
                    break;
                }
                int rightNumber = bombNumberIndex + bombPower;
                for (int j = bombNumberIndex; j <= rightNumber; j++)
                {
                    if (bombNumberIndex < numbers.Count)
                    {
                        numbers.RemoveAt(bombNumberIndex);
                    }
                    else
                    {
                        break;
                    }
                }
                int leftNumber = bombNumberIndex - bombPower;

                for (int j = bombNumberIndex - 1; j >= leftNumber; j--)
                {
                    if (j >= 0)
                    {
                        numbers.RemoveAt(j);
                    }
                    else
                    {
                        break;
                    }
                }
                i = -1;
            }

            int result = numbers.Sum();
            Console.WriteLine(result);
        }
    }
}
