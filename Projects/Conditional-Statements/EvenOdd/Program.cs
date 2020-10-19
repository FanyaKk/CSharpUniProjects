using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
//Четно или нечетно
//Да се напише програма, която чете цяло число въведено от потребителя и отпечатва на конзолата, дали е
//"четно" или "нечетно" (с думи).