using System;

namespace _09.MultuplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;

            while (number >= 0)
            {
                number = double.Parse(Console.ReadLine());
                number *= 2;
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                Console.WriteLine($"Result: {number:f2}");
            }
        }
    }
}
