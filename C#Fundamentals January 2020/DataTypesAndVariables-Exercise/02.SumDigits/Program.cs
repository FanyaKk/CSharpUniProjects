using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int num = 0;

            while (inputNumber != 0)
            {
                num += inputNumber % 10;
                inputNumber /= 10;
            }
            Console.WriteLine(num);
        }
    }
}
