using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentInfo = command.Split().ToArray();

                Student student = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Age = int.Parse(studentInfo[2]),
                    Hometown = studentInfo[3]
                };
                students.Add(student);

                command = Console.ReadLine();
            }
            string hometown = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(s => s.Hometown == hometown)
                .ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
