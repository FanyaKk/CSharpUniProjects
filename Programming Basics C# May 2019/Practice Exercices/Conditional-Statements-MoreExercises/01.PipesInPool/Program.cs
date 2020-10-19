using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firstPipeWater = firstPipe * hours;
            double secondPipeWater = secondPipe * hours;

            double waterVolume = firstPipeWater + secondPipeWater;
            double fillInPercents = 100 / (volume / waterVolume); // waterVolume / volume * 100

            double firstPipeInPercents = 100 / (waterVolume / firstPipeWater); // firstPipeWater / waterVolume * 100
            double secondPipeInPercents = 100 / (waterVolume / secondPipeWater); // secondPipeWater / waterVolume * 100


            if ( volume >= waterVolume)
            {
                Console.WriteLine($"The pool is {fillInPercents:f2}% full. Pipe 1: {firstPipeInPercents:f2}%. Pipe 2: {secondPipeInPercents:f2}%.");
            }
            else if ( volume < waterVolume)
            {
                double waterOverflow = waterVolume - volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {waterOverflow:f2} litres.");
            }
        }
    }
}
