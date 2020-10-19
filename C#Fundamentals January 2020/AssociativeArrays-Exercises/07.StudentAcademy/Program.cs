using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }
                studentsGrades[name].Add(grade);
            }
            studentsGrades = studentsGrades
                .OrderByDescending(kvp => kvp.Value.Average())
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var student in studentsGrades)
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
