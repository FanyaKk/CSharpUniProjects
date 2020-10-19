using System;

namespace _10.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            double back = 0;
            double chest = 0;
            double legs = 0;
            double abs = 0;
            double proteinShake = 0;
            double proteinBar = 0;

            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();

                if (activity == "Back")
                {
                    back++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                }
            }
            double trainersInPercents = (back + chest + legs + abs) / visitors * 100;
            double proteinBuyersInPercents = (proteinShake + proteinBar) / visitors * 100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{trainersInPercents:f2}% - work out");
            Console.WriteLine($"{proteinBuyersInPercents:f2}% - protein");
        }
    }
}
