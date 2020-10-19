using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumWater = length * width * height * 0.001;
            double aquariumPercent = percent / 100;
            double totalLitres = aquariumWater * (1 - aquariumPercent);

            Console.WriteLine($"{totalLitres:f3}");
        }
    }
}
