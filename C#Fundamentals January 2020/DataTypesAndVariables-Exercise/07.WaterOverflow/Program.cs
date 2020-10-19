using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int capacityTank = 255;

            for (int i = 0; i < inputCount; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > capacityTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacityTank -= liters;
                }
            }
            Console.WriteLine(255-capacityTank);
        }
    }
}
