using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            int[] peopleInEachWagon = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());

                peopleInEachWagon[i] = numberOfPeople;

                totalPeople += numberOfPeople;
            }
            for (int i = 0; i < peopleInEachWagon.Length; i++)
            {
                Console.Write($"{peopleInEachWagon[i]} ");
            }
            Console.WriteLine($"\n{totalPeople}");
        }
    }
}
