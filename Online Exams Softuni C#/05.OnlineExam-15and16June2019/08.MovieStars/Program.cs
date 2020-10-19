using System;

namespace _08.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actorName = Console.ReadLine();
            double wage = 0;

            while (actorName != "ACTION")
            {
                if (actorName.Length > 15)
                {
                    wage = budget * 0.2;
                }
                else
                {
                    wage = double.Parse(Console.ReadLine());
                }
                budget -= wage;
                if (budget < 0)
                {
                    break;
                }
                
                actorName = Console.ReadLine();
            }
            if (budget > 0)
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
            }
        }
    }
}
