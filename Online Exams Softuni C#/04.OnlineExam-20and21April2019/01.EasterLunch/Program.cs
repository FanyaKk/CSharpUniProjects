using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());
            int eggsDosenCount = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double numberOfEggs = eggsDosenCount * 12;
            double paintEggsPrice = numberOfEggs * 0.15;

            double easterBreadPrice = easterBreadCount * 3.2;
            double eggsPrice = (eggsDosenCount * 4.35) + paintEggsPrice;
            double cookiesPrice = cookiesKg * 5.40;

            double totalSum = easterBreadPrice + eggsPrice + cookiesPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
