using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            double savedMoney = 0;
            double totalSavedMoney = 0;

            while (destination !="End")
            {
                double budget = double.Parse(Console.ReadLine());

                while (budget > totalSavedMoney)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney += savedMoney;
                }
                if (budget <= totalSavedMoney)
                {
                    Console.WriteLine($"Going to {destination}!");
                    destination = Console.ReadLine();
                    totalSavedMoney = 0;
                }
            }
        }
    }
}
