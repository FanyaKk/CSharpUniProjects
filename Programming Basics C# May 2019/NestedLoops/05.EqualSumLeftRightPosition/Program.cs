using System;

namespace _05.EqualSumLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                //string number = i.ToString();

                int leftSum = 0;
                int rightSum = 0;
                int middleNum = 0;

                int fourthNum = i / 10;
                fourthNum %= 10;
                int fifthNum = i % 10;

                rightSum = fourthNum + fifthNum;

                int firstNum = i / 10000;
                int secondNum = i / 1000;
                secondNum %= 10;

                leftSum = firstNum + secondNum;
                middleNum = i % 1000;
                middleNum /= 100;


                //for (int j = 0; j < number.Length; j++)
                //{
                //    int currentNumberToDigit = int.Parse(number[j].ToString());

                //    if (j < 2)
                //    {
                //        leftSum += currentNumberToDigit;
                //    }
                //    else if (j > 2)
                //    {
                //        rightSum += currentNumberToDigit;
                //    }
                //    else
                //    {
                //        middleNum += currentNumberToDigit;
                //    }
                //}
                if (leftSum < rightSum)
                {
                    leftSum += middleNum;
                }
                else if (rightSum < leftSum)
                {
                    rightSum += middleNum;
                }
                if (leftSum == rightSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
