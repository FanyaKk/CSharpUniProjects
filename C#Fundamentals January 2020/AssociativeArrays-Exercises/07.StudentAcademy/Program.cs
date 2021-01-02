using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(grade);
            }
            students = students
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine(string.Join(Environment.NewLine, students.Select(x=>$"{x.Key} -> {x.Value.Average():f2}")));
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();


        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        string name = Console.ReadLine();
        //        double grade = double.Parse(Console.ReadLine());

        //        if (!studentsGrades.ContainsKey(name))
        //        {
        //            studentsGrades.Add(name, new List<double>());
        //        }
        //        studentsGrades[name].Add(grade);
        //    }
        //    studentsGrades = studentsGrades
        //        .OrderByDescending(kvp => kvp.Value.Average())
        //        .ToDictionary(a => a.Key, b => b.Value);

        //    foreach (var student in studentsGrades)
        //    {
        //        if (student.Value.Average() >= 4.5)
        //        {
        //            Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
        //        }
        //    }
        //}
    }
}
//7. Student Academy
//
//Write a program that keeps information about students and their grades.
//You will receive n pair of rows.First you will receive the student's name, after that you will receive his grade. Check
//if the student already exists and if not, add him. Keep track of all grades for each student.
//When you finish reading the data, keep the students with average grade higher than or equal to 4.50. Order the
//filtered students by average grade in descending order.
//Print the students and their average grade in the following format:
//{ name} –&gt; {averageGrade}
//Format the average grade to the 2 nd decimal place.

//Examples

//Input                         Output
//---------------------------------------------------
//5                             John -> 5.00
//John                          George -> 5.00
//5.5                           Alice -> 4.50
//John
//4.5
//Alice
//6
//Alice
//3
//George
//5
//---------------------------------------------------
//5                             Robert -> 6.00
//Amanda                        Rob -> 5.50
//3.5                           Christian -> 5.00
//Amanda
//4
//Rob
//5.5
//Christian
//5
//Robert
//6