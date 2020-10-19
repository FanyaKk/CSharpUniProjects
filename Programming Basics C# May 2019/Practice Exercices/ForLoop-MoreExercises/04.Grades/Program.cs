using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());

            double grade = 0; 

            int failStudent = 0;
            int middleStudent = 0;
            int goodStudent = 0;
            int topStudent = 0;

            double failPercents = 0;
            double middlePercents = 0;
            double goodPercents = 0;
            double topPercents = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrade < 3)
                {
                    failStudent++;
                }
                else if (studentGrade < 4)
                {
                    middleStudent++;
                }
                else if (studentGrade < 5)
                {
                    goodStudent++;
                }
                else if (studentGrade >= 5)
                {
                    topStudent++;
                }
                grade += studentGrade;
            }
            failPercents = failStudent / studentsCount * 100;
            middlePercents = middleStudent / studentsCount * 100;
            goodPercents = goodStudent / studentsCount * 100;
            topPercents = topStudent / studentsCount * 100;

            double averageSuccess = grade / studentsCount;

            Console.WriteLine($"Top students: {topPercents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodPercents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {middlePercents:f2}%");
            Console.WriteLine($"Fail: {failPercents:f2}%");
            Console.WriteLine($"Average: {averageSuccess:f2}");
        }
    }
}
