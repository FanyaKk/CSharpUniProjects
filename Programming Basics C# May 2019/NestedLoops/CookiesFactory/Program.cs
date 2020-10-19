using System;

namespace CookiesFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchNumber = int.Parse(Console.ReadLine());
            
            int flourCount = 0;
            int eggsCount = 0;
            int sugarCount = 0;

            for (int backingBatchNumber = 1; backingBatchNumber <= batchNumber; backingBatchNumber++)
            {
                string product = Console.ReadLine();

                while (product != "Bake!")
                {
                    if (product == "flour")
                    {
                        flourCount++;
                    }
                    else if (product == "eggs")
                    {
                        eggsCount++;
                    }
                    else if (product == "sugar")
                    {
                        sugarCount++;
                    }
                    product = Console.ReadLine();
                }
                if (product == "Bake!")
                {
                    if (flourCount >= 1 && eggsCount >= 1 && sugarCount >= 1)
                    {
                        Console.WriteLine($"Baking batch number {backingBatchNumber}...");
                        flourCount = 0;
                        eggsCount = 0;
                        sugarCount = 0;
                    }
                    else
                    {
                        Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        backingBatchNumber--;
                    }
                }
            }
        }
    }
}
