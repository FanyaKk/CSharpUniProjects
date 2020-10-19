using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapePerKilo = double.Parse(Console.ReadLine());
            int wineForSelling = int.Parse(Console.ReadLine());
            int laborer = int.Parse(Console.ReadLine());

            double grapeForWine = vineyard * 0.4;
            double totalKilogramsOfGrape = grapeForWine * grapePerKilo;
            double wineLiters = totalKilogramsOfGrape / 2.5;

            double remainingWine = Math.Ceiling(wineLiters - wineForSelling);
            double litersPerPerson = Math.Ceiling(remainingWine / laborer);

            if (wineForSelling > wineLiters)
            {
                double neededWine = Math.Floor(wineForSelling - wineLiters);
                Console.WriteLine($"It will be a tough winter! More {neededWine} liters wine needed.");
            }
            else if (wineForSelling <= wineLiters)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{remainingWine} liters left -> {litersPerPerson} liters per person.");
            }
        }
    }
}
