using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeCount = double.Parse(Console.ReadLine());

            int counter = 0;
            double sum = 0;
            double totalBalance = 0;

            while (counter < incomeCount)
            {
                sum = double.Parse(Console.ReadLine());
                if (sum < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    counter++;
                    totalBalance += sum;
                    Console.WriteLine($"Increase: {sum:f2}");
                }
            }
            Console.WriteLine($"Total: {totalBalance:f2}");
        }
    }
}
