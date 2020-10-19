using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int max = int.MinValue;

            while (count < n)
            {
                int number = int.Parse(Console.ReadLine());
                count++;
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
//Най-голямо число

//Напишете програма, която чете n-на брой цели числа(n > 0), въведени от потребителя, и намира най-голямото измежду тях. Първо се въвежда броят числа n, а след това самите n числа, по едно на ред.