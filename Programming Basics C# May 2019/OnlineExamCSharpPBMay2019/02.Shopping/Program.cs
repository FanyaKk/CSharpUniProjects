using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocardsPrice = videocards * 250;
            double processorsPrice = processors * videocardsPrice * 0.35;
            double ramPrice = ram * videocardsPrice * 0.1;

            double totalPrice = videocardsPrice + processorsPrice + ramPrice;

            if (videocards > processors)
            {
                totalPrice *= 0.85;
            }
            double diff = Math.Abs(totalPrice - budget);
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {diff:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
            }
        }
    }
}
