using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] specialNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = specialNumbers[0];
            int power = specialNumbers[1];
            int lastIndex = numbers.Count - 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int startIndex = i - power;
                    int countOfRemovalNumbers = power * 2 + 1;

                    if (startIndex >= 0 && startIndex + countOfRemovalNumbers < numbers.Count)
                    {
                        numbers.RemoveRange(startIndex, countOfRemovalNumbers);
                    }
                    else if (startIndex < 0 && startIndex + countOfRemovalNumbers >= numbers.Count)
                    {
                        startIndex = 0;
                        countOfRemovalNumbers = numbers.Count - startIndex;
                        numbers.RemoveRange(startIndex, countOfRemovalNumbers);
                    }
                    else if (startIndex < 0)
                    {
                        startIndex = 0;
                        numbers.RemoveRange(startIndex, countOfRemovalNumbers);
                    }
                    else if (startIndex + countOfRemovalNumbers >= numbers.Count)
                    {
                        countOfRemovalNumbers = numbers.Count - startIndex;
                        numbers.RemoveRange(startIndex, countOfRemovalNumbers);
                    }
                    i = -1;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
        //static void Main(string[] args)             //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine()
        //    .Split()
        //    .Select(int.Parse)
        //    .ToList();
        //    int[] bombInfo = Console.ReadLine()
        //    .Split()
        //    .Select(int.Parse)
        //    .ToArray();

        //    int bombNumber = bombInfo[0];
        //    int bombPower = bombInfo[1];

        //    //while (true)
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        int bombNumberIndex = numbers.IndexOf(bombNumber);
        //        if (bombNumberIndex < 0 || bombNumberIndex > numbers.Count - 1)
        //        {
        //            break;
        //        }
        //        int rightNumber = bombNumberIndex + bombPower;
        //        for (int j = bombNumberIndex; j <= rightNumber; j++)
        //        {
        //            if (bombNumberIndex < numbers.Count)
        //            {
        //                numbers.RemoveAt(bombNumberIndex);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        int leftNumber = bombNumberIndex - bombPower;

        //        for (int j = bombNumberIndex - 1; j >= leftNumber; j--)
        //        {
        //            if (j >= 0)
        //            {
        //                numbers.RemoveAt(j);
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        i = -1;
        //    }

        //    int result = numbers.Sum();
        //    Console.WriteLine(result);
        //}
    }
}
//Exercise 5. Bomb Numbers

//Write a program that reads a sequence of numbers and a special bomb number with a certain power.Your task is
//to detonate every occurrence of the special bomb number and according to its power - his neighbors from left and
//right. Detonations are performed from left to right and all detonated numbers disappear. Finally print the sum of
//the remaining elements in the sequence.
//Examples
//Input                     |    Output | Comments
//----------------------------------------------------------------------------------------------------------------
//1 2 2 4 2 2 2 9           |    12     | Special number is 4 with power 2. After detontaion we are left with the
//4 2                       |           | sequence [1, 2, 9] with sum 12.
// ----------------------------------------------------------------------------------------------------------------
//1 4 4 2 8 9 1             |    5      | Special number is 9 with power 3. After detontaion we are left with the
//9 3                       |           | sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the
//                          |           | right we remove just it (one number instead of 3).
//----------------------------------------------------------------------------------------------------------------
//1 7 7 1 2 3               |    6      | Detonations are performed from left to right.We cannot detonate the
//7 1                       |           | second occurance of 7, because its already destroyed by the first
//                          |           | occurance.The numbers[1, 2, 3] survive. Their sum is 6.
//----------------------------------------------------------------------------------------------------------------
//1 1 2 1 1 1 2 1 1 1       |    4      | The red and yellow numbers disappear in two sequential detonations.
//2 1                       |           | The result is the sequence [1, 1, 1, 1]. Sum = 4.