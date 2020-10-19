using System;

namespace _09.FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfItems; i++)
            {
                string item = Console.ReadLine();

                if (item == "hoodie")
                {
                    budget -= 30;
                }
                else if (item == "keychain")
                {
                    budget -= 4;
                }
                else if (item == "T-shirt")
                {
                    budget -= 20;
                }
                else if (item == "flag")
                {
                    budget -= 15;
                }
                else if (item == "sticker")
                {
                    budget -= 1;
                }
            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought {numberOfItems} items and left with {budget} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget)} more lv.");
            }
        }
    }
}
