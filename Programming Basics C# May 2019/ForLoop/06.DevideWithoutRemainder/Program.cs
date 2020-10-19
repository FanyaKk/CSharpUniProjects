using System;

namespace _06.DevideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            int numberDTwo = 0;
            int numberDThree = 0;
            int numberDFour = 0;

            double resultDTwo = 0;
            double resultDThree = 0;
            double resultDFour = 0;

            for (int i = 0; i < numbers; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                if (nextNumber % 2 == 0)
                {
                    numberDTwo++;
                }
                if (nextNumber % 3 == 0)
                {
                    numberDThree++;
                }
                if (nextNumber % 4 == 0)
                {
                    numberDFour++;
                }
            }
            resultDTwo = numberDTwo / numbers * 100;
            resultDThree = numberDThree / numbers * 100;
            resultDFour = numberDFour / numbers * 100;

            Console.WriteLine($"{resultDTwo:f2}%");
            Console.WriteLine($"{resultDThree:f2}%");
            Console.WriteLine($"{resultDFour:f2}%");
        }
    }
}
