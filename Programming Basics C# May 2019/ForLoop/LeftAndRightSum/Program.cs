using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int readingNumber = int.Parse(Console.ReadLine());

            int countNumber = 0;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < readingNumber * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                countNumber++;

                if (countNumber <= readingNumber)
                {
                    leftSum += number;
                }
                else if (countNumber <= readingNumber * 2)
                {
                    rightSum += number;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
