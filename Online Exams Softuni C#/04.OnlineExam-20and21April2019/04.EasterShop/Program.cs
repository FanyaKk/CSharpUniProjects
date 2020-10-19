using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            int totalBoughtEggs = 0;

            string command = Console.ReadLine();
            while (command != "Close")
            {
                int eggsFillBuy = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (eggsCount < eggsFillBuy)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsCount}.");
                        break;
                    }
                    totalBoughtEggs += eggsFillBuy;
                    eggsCount -= eggsFillBuy;
                }
                else if (command == "Fill")
                {
                    eggsCount += eggsFillBuy;
                }
                command = Console.ReadLine();
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{totalBoughtEggs} eggs sold.");
            }
        }
    }
}
