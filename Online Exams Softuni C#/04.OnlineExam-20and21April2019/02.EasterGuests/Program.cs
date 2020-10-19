using System;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestsCount = double.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double easterBreadCount = Math.Ceiling(guestsCount / 3);
            double eggsCount = guestsCount * 2;

            double easterBreadPrice = easterBreadCount * 4;
            double eggsPrice = eggsCount * 0.45;

            double totalPrice = easterBreadPrice + eggsPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {easterBreadCount} Easter bread and {eggsCount} eggs.");
                Console.WriteLine($"He has {budget - totalPrice:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice - budget:F2} lv. more.");
            }
        }
    }
}
