using System;

namespace _04.NumberOfIntegers
{
    class NumberOfIntegers
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            int numberCount = int.Parse(Console.ReadLine());

            for (int i = 0; i > numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(number < minNumber)
                {
                    minNumber = number;
                }
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"Max Number: {maxNumber}");
            Console.WriteLine($"Min Number: {minNumber}");
        }
    }
}
