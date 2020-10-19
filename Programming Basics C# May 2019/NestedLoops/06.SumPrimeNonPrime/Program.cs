using System;

namespace _06.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            int nonPrime = 0;

            string command = Console.ReadLine();
            
            while (command != "stop")
            {
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if ((number % 2 == 0 || number % 3 == 0 || number == 1) && number != 2 && number != 3 && number != 0)
                {
                    nonPrime += number;
                }
                else
                {
                    prime += number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}
