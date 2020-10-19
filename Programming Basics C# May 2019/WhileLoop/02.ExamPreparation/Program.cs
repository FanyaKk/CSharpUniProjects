using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            int counterPoorGrades = 0;
            double sumGrades = 0;
            int counterForGrades = 0;
            double grade = 0;

            string taskName = Console.ReadLine();
            string lastTask = "";

            while (taskName != "Enough")
            {
                grade = double.Parse(Console.ReadLine());

                sumGrades += grade;
                counterForGrades++;

                if (grade <= 4)
                {
                    counterPoorGrades++;
                }
                if (poorGrades == counterPoorGrades)
                {
                    Console.WriteLine($"You need a break, {counterPoorGrades} poor grades.");
                    return;
                }

                lastTask = taskName;
                taskName = Console.ReadLine();
            }
            double averageScore = sumGrades / counterForGrades;

            Console.WriteLine($"Average score: {averageScore:f2}");
            Console.WriteLine($"Number of problems: {counterForGrades}");
            Console.WriteLine($"Last problem: {lastTask}");
        }
    }
}
