using System;

namespace _07.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double averageGrade = 0;
            int averageCount = 0;
            int i = 0;
            double totalAverageGrade = 0;

            while (presentationName != "Finish")
            {
                double gradeSum = 0;

                for (i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    gradeSum += grade;
                }
                averageGrade = gradeSum / i;
                averageCount++;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
                totalAverageGrade += averageGrade;

                presentationName = Console.ReadLine();
            }
            totalAverageGrade /= averageCount;
            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");
        }
    }
}
