using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            PrintFactorialResult(firstNum, secondNum);
        }
        static void PrintFactorialResult(double firstNumber, double secondNumber)
        {
            for (double i = firstNumber - 1; i > 0; i--)
            {
                firstNumber *= i;
            }
            for (double i = secondNumber - 1; i > 0; i--)
            {
                secondNumber *= i;
            }
            double result = firstNumber / secondNumber;
            Console.WriteLine($"{result:F2}");
        }
    }
}
