using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberInMeters = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "cm")
            {
                numberInMeters /= 100;
            }
            else if (input == "mm")
            {
                numberInMeters /= 1000;
            }
            if (output == "cm")
            {
                numberInMeters *= 100;
            }
            else if (output == "mm")
            {
                numberInMeters *= 1000;
            }
            Console.WriteLine($"{numberInMeters:f3}");
        }
    }
}
