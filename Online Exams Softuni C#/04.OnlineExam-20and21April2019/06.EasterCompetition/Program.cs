using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBakeCount = int.Parse(Console.ReadLine());
            string bakerName = "";
            string topBakerName = "";
            int topGrade = 0;

            for (int i = 1; i <= easterBakeCount; i++)
            {
                bakerName = Console.ReadLine();
                string strGrade = Console.ReadLine();

                int gradeSum = 0;

                while (strGrade != "Stop")
                {
                    int grade = int.Parse(strGrade);
                    gradeSum += grade;

                    strGrade = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {gradeSum} points.");
                if (topGrade < gradeSum)
                {
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    topBakerName = bakerName;
                    topGrade = gradeSum;
                }
            }
            Console.WriteLine($"{topBakerName} won competition with {topGrade} points!");
        }
    }
}
