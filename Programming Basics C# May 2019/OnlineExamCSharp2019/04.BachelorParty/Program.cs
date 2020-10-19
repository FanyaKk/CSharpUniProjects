using System;

namespace _04.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestPerformentPrice = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            double priceForOnePerson = 0;
            double groupPrice = 0;
            double totalGroupPrice = 0;
            double totalNumberOfPeople = 0;

            while (command != "The restaurant is full")
            {
                int numberOfPeople = int.Parse(command);

                if (numberOfPeople < 5)
                {
                    priceForOnePerson = 100;
                    groupPrice = numberOfPeople * priceForOnePerson;

                }
                else if (numberOfPeople >= 5)
                {
                    priceForOnePerson = 70;
                    groupPrice = numberOfPeople * priceForOnePerson;
                }
                totalNumberOfPeople += numberOfPeople;
                totalGroupPrice += groupPrice;
                command = Console.ReadLine();
            }
            
            if (command == "The restaurant is full")
            {
                double leftSum = Math.Abs(guestPerformentPrice - totalGroupPrice);
                if (guestPerformentPrice <= totalGroupPrice)
                {
                    Console.WriteLine($"You have {totalNumberOfPeople} guests and {leftSum} leva left.");
                }
                else
                {
                    Console.WriteLine($"You have {totalNumberOfPeople} guests and {totalGroupPrice} leva income, but no singer.");
                }
            }
        }
    }
}
