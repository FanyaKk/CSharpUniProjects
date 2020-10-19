using System;

namespace _10.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());

            double totalJuryScore = 0;
            double totalScore = 0;

            for (int i = 1; i <= juryCount; i++)
            {
                string juryName = Console.ReadLine();
                double juryScore = double.Parse(Console.ReadLine());

                int juryNameLength = juryName.Length;
                totalJuryScore += juryNameLength * juryScore / 2;
                totalScore = academyScore + totalJuryScore;

                if (totalScore > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalScore:F1}!");
                    break;
                }
            }
            if (totalScore < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5-totalScore:F1} more!");
            }
        }
    }
}
