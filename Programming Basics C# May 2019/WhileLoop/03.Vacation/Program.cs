using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double jesiesMoney = double.Parse(Console.ReadLine());

            int count = 0;
            int totalCount = 0;

            while (moneyForVacation > jesiesMoney)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalCount++;

                if (command == "save")
                {
                    jesiesMoney += money;
                    count = 0;
                }
                else if (command == "spend")
                {
                    jesiesMoney -= money;
                    count++;

                    if (jesiesMoney < 0)
                    {
                        jesiesMoney = 0;
                    }
                }
                if (count == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(totalCount);
                    break;
                }
            }
            if (moneyForVacation <= jesiesMoney)
            {
                Console.WriteLine($"You saved the money for {totalCount} days.");
            }
        }
    }
}
