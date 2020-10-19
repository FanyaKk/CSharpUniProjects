using System;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBakeCount = int.Parse(Console.ReadLine());

            double totalSugar = 0;
            double totalFlour = 0;


            double maxSugarValue = 0;
            double maxFlourValue = 0;

            for (int i = 0; i < easterBakeCount; i++)
            {
                int sugarSpare = int.Parse(Console.ReadLine());
                int flourSpare = int.Parse(Console.ReadLine());

                totalSugar += sugarSpare;
                totalFlour += flourSpare;

                if (maxSugarValue < sugarSpare)
                {
                    maxSugarValue = sugarSpare;
                }
                if (maxFlourValue < flourSpare)
                {
                    maxFlourValue = flourSpare;
                }
            }

            double sugarPack = Math.Ceiling(totalSugar/950);
            double flourPack = Math.Ceiling(totalFlour/750);

            Console.WriteLine($"Sugar: {sugarPack}");
            Console.WriteLine($"Flour: {flourPack}");
            Console.WriteLine($"Max used flour is {maxFlourValue} grams, max used sugar is {maxSugarValue} grams.");
        }
    }
}
