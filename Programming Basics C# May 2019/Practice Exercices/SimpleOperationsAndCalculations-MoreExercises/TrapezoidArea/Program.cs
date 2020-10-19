using System;

namespace _01.TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double leftSide = double.Parse(Console.ReadLine());
            double rightSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (leftSide + rightSide) * height / 2;

            Console.WriteLine($"{area:f2}");
        }
    }
}
