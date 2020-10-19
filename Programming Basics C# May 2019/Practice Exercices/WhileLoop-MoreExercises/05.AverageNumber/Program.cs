using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
f
            int number = int.Parse(Console.ReadLine());

            int countNumber = 0;
            double result = 0;
            double average = 0;

            while (number > countNumber)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                countNumber++;
                result += nextNumber;
            }
            if (number <= countNumber)
            {
                average = result / countNumber;
                Console.WriteLine($"{average:f2}");
            }
        }
    }
}
