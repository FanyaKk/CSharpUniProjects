using System;

namespace _07.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            int peopleSum = 0;

            string command = Console.ReadLine();

            while (command != "Movie time!")
            {
                int numberOfPeople = int.Parse(command);
                peopleSum += numberOfPeople;
                if (peopleSum > hallCapacity)
                {
                    peopleSum -= numberOfPeople;
                    Console.WriteLine($"The cinema is full.");
                    break;
                }
                int currentIncome = numberOfPeople * 5;
                if (numberOfPeople % 3 == 0)
                {
                    currentIncome -= 5;
                }
                totalIncome += currentIncome;
                command = Console.ReadLine();
            }
            double leftPlaces = hallCapacity - peopleSum;
            if(command == "Movie time!")
            {
                Console.WriteLine($"There are {leftPlaces} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {totalIncome} lv.");
        }
    }
}
