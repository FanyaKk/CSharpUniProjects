using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());

            string cocktailName = Console.ReadLine();

            double cocktailPrice = 0;
            double totalCocktailsPrice = 0;

            while (cocktailName != "Party!")
            {
                int numberOfCocktails = int.Parse(Console.ReadLine());

                cocktailPrice = cocktailName.Length * numberOfCocktails;

                if (cocktailPrice % 2 != 0)
                {
                    cocktailPrice *= 0.75;
                }
                totalCocktailsPrice += cocktailPrice;

                if (totalCocktailsPrice >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                cocktailName = Console.ReadLine();
            }
            if(cocktailName == "Party!")
            {
                double neededMoney = desiredProfit - totalCocktailsPrice;
                Console.WriteLine($"We need {neededMoney:f2} leva more.");
            }
            Console.WriteLine($"Club income - {totalCocktailsPrice:f2} leva.");
        }
    }
}
