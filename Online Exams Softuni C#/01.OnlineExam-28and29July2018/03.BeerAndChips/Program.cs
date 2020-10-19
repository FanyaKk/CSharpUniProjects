using System;

namespace _03.BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberOfbottles = int.Parse(Console.ReadLine());
            int numberOfChipsPacket = int.Parse(Console.ReadLine());

            double beerTotalPrice = numberOfbottles * 1.2;
            double chipsTotalPrice = Math.Ceiling(numberOfChipsPacket * (beerTotalPrice * 0.45));

            double totalAmount = beerTotalPrice + chipsTotalPrice;

            double leftNeededMoney = Math.Abs(budget - totalAmount);

            if(budget >= totalAmount)
            {
                Console.WriteLine($"{name} bought a snack and has {leftNeededMoney:f2} leva left.");
            }
            else if (budget < totalAmount)
            {
                Console.WriteLine($"{name} needs {leftNeededMoney:f2} more leva!");
            }
        }
    }
}
