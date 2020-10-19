using System;

namespace _04.EqualSumEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string number = i.ToString();

                for (int j = 0; j < number.Length; j++)
                {
                    char symbol = number[j];
                    int symbolToNumber = int.Parse(symbol.ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += symbolToNumber;
                    }
                    else
                    {
                        oddSum += symbolToNumber;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
                evenSum = 0;
                oddSum = 0;
            }
        }
    }
}
