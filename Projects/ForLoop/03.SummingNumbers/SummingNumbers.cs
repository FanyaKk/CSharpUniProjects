using System;

namespace _03.SummingNumbers
{
    class SummingNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter count of numbers, you want to summing:"); 
            int numberCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine("Please enter e number:");
                int num = int.Parse(Console.ReadLine());
                sum += num; 
            }
            Console.WriteLine($"The result is : {sum}");
        }
    }
}
