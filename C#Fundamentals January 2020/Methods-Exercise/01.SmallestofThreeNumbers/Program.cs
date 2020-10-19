using System;
using System.Linq;

namespace _01.SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
          
            int smallest = SmallestOfThree(first, second, third);
            Console.WriteLine(smallest);

        }
        static int SmallestOfThree(int a, int b, int c)
        {
            int currSmallest = Math.Min(a, Math.Min(b, c));

            return currSmallest;
        }






        //int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ////int[] secondArr = firstArr;

            ////Console.WriteLine(firstArr[0]);
            //PrintArr(firstArr);
            ////Console.WriteLine(firstArr[0]);

            //static void PrintArr(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write(arr[i].ToString());
            //    }
            //    //arr[0] = 11;
            //}
    }
}
