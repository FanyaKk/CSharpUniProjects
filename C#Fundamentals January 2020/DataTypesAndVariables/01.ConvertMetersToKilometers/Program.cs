using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            //decimal value = 1000;
            //decimal kilometers = meters / value;
            decimal kilometers = meters / 1000.0m;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
