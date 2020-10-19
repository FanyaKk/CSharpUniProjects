using System;
using System.Linq;
using System.Numerics;

namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                BigInteger[] number = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
                BigInteger maxNumber = 0;

                if (number[0] > number[1])
                {
                    maxNumber = BigInteger.Abs(number[0]);
                }
                else
                {
                    maxNumber = BigInteger.Abs(number[1]);
                }
                BigInteger sumMaxNumber = 0;
                while (maxNumber != 0)
                {
                    sumMaxNumber += maxNumber % 10;
                    maxNumber /= 10;
                }
                Console.WriteLine(BigInteger.Abs(sumMaxNumber));
            }
            

            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    string number = Console.ReadLine();
            //    int position = number.IndexOf(" ");
            //    string strBeforeSpace = number.Substring(0, position);
            //    string strAfterSpace = number.Substring(position + 1);
            //    BigInteger leftNumber = BigInteger.Parse(strBeforeSpace);
            //    BigInteger rightNumber = BigInteger.Parse(strAfterSpace);
            //    //BigInteger maxNumber = Math.Max(Math.Abs(leftNumber), Math.Abs(rightNumber));
            //    BigInteger maxNumber = 0;
            //    if (leftNumber > rightNumber)
            //    {
            //        maxNumber = BigInteger.Abs(leftNumber);
            //    }
            //    else
            //    {
            //        maxNumber = BigInteger.Abs(rightNumber);
            //    }
            //    BigInteger sumMaxNumber = 0;

            //    while (maxNumber > 0)
            //    {
            //        sumMaxNumber += maxNumber % 10;
            //        maxNumber /= 10;
            //    }
            //    Console.WriteLine(BigInteger.Abs(sumMaxNumber));

            //}
        }
    }
}

