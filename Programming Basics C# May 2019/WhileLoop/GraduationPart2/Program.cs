using System;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int count = 1;
            double sum = 0;
            int breakCount = 0;

            while (count <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    count++;
                }
                else if (grade < 4)
                {
                    breakCount++;
                }
                if (breakCount == 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {count} grade");
                    break;
                }
            }
            if (breakCount < 2)
            {
                double averageGrade = sum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
