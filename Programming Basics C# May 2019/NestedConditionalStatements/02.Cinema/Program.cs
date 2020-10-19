using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double numberOfPlaces = row * column;
            double totalIncome = 0;

            if (projectType == "Premiere")
            {
                totalIncome = numberOfPlaces * 12;
            }
            else if (projectType == "Normal")
            {
                totalIncome = numberOfPlaces * 7.5;
            }
            else if (projectType == "Discount")
            {
                totalIncome = numberOfPlaces * 5;
            }
            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
