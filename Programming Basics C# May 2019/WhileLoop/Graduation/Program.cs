using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int nextClass = 0;
            double sum = 0;

            while (nextClass < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    nextClass++;
                }
            }
            double averageGrade = sum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
