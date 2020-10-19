using System;

namespace ExperienceGaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());

            double totalExperience = 0;
            bool hasNeededExperience = false;

            for (int i = 1; i <= battleCount; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    experiencePerBattle += experiencePerBattle * 0.15;
                }
                if (i % 5 == 0)
                {
                    experiencePerBattle -= experiencePerBattle * 0.1;
                }
                totalExperience += experiencePerBattle;
                if (totalExperience >= neededExperience)
                {
                    hasNeededExperience = true;
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }
            }
            if (hasNeededExperience == false)
            {
                neededExperience -= totalExperience;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }

        }
    }
}
