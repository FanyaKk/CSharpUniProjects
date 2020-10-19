using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int totalNumbers = numbersCount * 2;
            double difference = double.MinValue;
            double totalDiff = double.MinValue;

            double sum = 0;
            double pairSum = 0;

            for (int i = 1; i <= totalNumbers; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum += number;

                if (i % 2 == 0)
                {
                    if (sum != pairSum && i > 2)
                    {
                        difference = Math.Abs(sum - pairSum);
                        if (difference > totalDiff)
                        {
                            totalDiff = difference;
                        }
                    }
                    pairSum = sum;
                    sum = 0;
                }
            }
            if (totalDiff != double.MinValue)
            {
                Console.WriteLine($"No, maxdiff={totalDiff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={pairSum}");
            }
        }
    }
}
