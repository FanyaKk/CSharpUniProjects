using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double bonus = 0;
            double maxBonus = 0;
            double maxAttendencies = 0;

            for (int i = 1; i <= countStudents; i++)
            {
                double attendencies = double.Parse(Console.ReadLine());

                bonus = attendencies / lecturesCount * (5 + additionalBonus);
                if (maxBonus < bonus)
                {
                    maxBonus = Math.Ceiling(bonus);
                    maxAttendencies = attendencies;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendencies} lectures.");
        }
    }
}
