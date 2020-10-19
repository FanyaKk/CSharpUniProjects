using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            double envelopePrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;

            if(guestCount >= 10 && guestCount <= 15)
            {
                envelopePrice *= 0.85;
            }
            else if (guestCount > 15 && guestCount <= 20)
            {
                envelopePrice *= 0.8;
            }
            else if (guestCount >20)
            {
                envelopePrice *= 0.75;
            }

            double totalSum = (guestCount * envelopePrice) + cakePrice;

            if (budget >= totalSum)
            {
                Console.WriteLine($"It is party time! {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalSum - budget:F2} leva needed.");
            }
        }
    }
}
