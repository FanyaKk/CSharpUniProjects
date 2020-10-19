using System;
using System.Linq;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            ResultOfThreeNumbers(firstNum, secondNum, thirdNum);

        }
        static void ResultOfThreeNumbers(int firstNum, int secondNum, int thirdNum)
        {
            int[] arraySum = {firstNum, secondNum };

            int result = arraySum.Sum() - thirdNum;

            Console.WriteLine(result);
        }
    }
}
