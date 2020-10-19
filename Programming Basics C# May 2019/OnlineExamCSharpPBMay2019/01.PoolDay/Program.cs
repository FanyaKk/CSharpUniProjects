using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double loungePrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalEntryTax = people * entryTax;
            double lounges = Math.Ceiling(people * 0.75);
            double umbrellas = Math.Ceiling(people / 2.0);

            loungePrice *= lounges;
            umbrellaPrice *= umbrellas;

            double totalPrice = totalEntryTax + loungePrice + umbrellaPrice;

            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
