using System;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double mashineCost = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int evenMoney = 0;
            int toyCount = 0;
            int moneyCount = 0;
            int moneyPresent = 0;

            for (int ageCount = 1; ageCount <= ageOfLilly; ageCount++)
            {
                if (ageCount % 2 == 0)
                {
                    evenMoney += 10;
                    moneyPresent += evenMoney;
                    moneyCount++;
                }
                else
                {
                    toyCount++;
                }
            }
            int brotherTaken = moneyCount;
            moneyPresent -= brotherTaken;
            int moneyFromToys = toyCount * toyPrice;
            int totalMoney = moneyFromToys + moneyPresent;
            double diff = Math.Abs(totalMoney - mashineCost);

            if (totalMoney >= mashineCost)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
