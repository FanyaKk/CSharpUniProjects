using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] student = Console.ReadLine().Split();

                string firstName = student[0];
                string lastName = student[1];
                float grade = float.Parse(student[2]);

                Students students = new Students(firstName, lastName, grade);
                studentsList.Add(students);
            }

            studentsList = studentsList
                .OrderByDescending(g => g.Grade)
                .ToList();

            //foreach (var student in studentsList)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}"); foreach цикъла се използва, ако не сме изпозлвали override на ToString() метода в класа Students
            //}
            Console.WriteLine(string.Join(Environment.NewLine, studentsList));
        }
    }
}
