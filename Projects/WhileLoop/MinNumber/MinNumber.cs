using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int min = int.MaxValue;

            while (count < n)
            {
                int number = int.Parse(Console.ReadLine());
                count++;
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
//Най-малко число

//Напишете програма, която чете n-на брой цели числа (n > 0), въведени от потребителя и намира най-малкото измежду тях.Първо се въвежда броят числа n, а след това самите n числа, по едно на ред.