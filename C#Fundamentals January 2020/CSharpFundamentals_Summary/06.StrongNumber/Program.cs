using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numChanger = number;

            double totalSum = 0;

            while (numChanger > 0)
            {
                int digit = numChanger % 10;
                numChanger /= 10;
                int sum = 1;

                for (int i = digit; i > 0; i--)
                {
                    sum *= i;
                }
                totalSum += sum;
            }
            if (totalSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
