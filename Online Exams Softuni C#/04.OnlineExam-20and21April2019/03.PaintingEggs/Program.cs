using System;

namespace _03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColour = Console.ReadLine();
            int batchCount = int.Parse(Console.ReadLine());

            double sells = 0.0;

            if(eggsSize == "Large")
            {
                if (eggsColour == "Red")
                {
                    sells = batchCount * 16;
                }
                else if (eggsColour == "Green")
                {
                    sells = batchCount * 12;
                }
                else if (eggsColour == "Yellow")
                {
                    sells = batchCount * 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if(eggsColour == "Red")
                {
                    sells = batchCount * 13;
                }
                else if (eggsColour == "Green")
                {
                    sells = batchCount * 9;
                }
                else if (eggsColour == "Yellow")
                {
                    sells = batchCount * 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (eggsColour == "Red")
                {
                    sells = batchCount * 9;
                }
                else if (eggsColour == "Green")
                {
                    sells = batchCount * 8;
                }
                else if (eggsColour == "Yellow")
                {
                    sells = batchCount * 5;
                }
            }
            double totalIncome = sells * 0.65;

            Console.WriteLine($"{totalIncome:F2} leva.");
        }
    }
}
