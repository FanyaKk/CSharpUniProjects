using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowerType == "Roses")
            {
                price = flowerCount * 5;

                if (flowerCount > 80)
                {
                    price *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = flowerCount * 3.80;

                if (flowerCount > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = flowerCount * 2.80;

                if (flowerCount > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = flowerCount * 3;

                if (flowerCount < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = flowerCount * 2.50;

                if (flowerCount < 80)
                {
                    price += price * 0.2;
                }
            }
            double neededMoney = Math.Abs(budget - price);
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {neededMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}
