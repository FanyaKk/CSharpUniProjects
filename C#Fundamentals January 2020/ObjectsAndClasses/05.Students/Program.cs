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
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentInfo = command.Split();
                Student student = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Age = int.Parse(studentInfo[2]),
                    Hometown = studentInfo[3]
                };
                students.Add(student);
            }
            string town = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(s => s.Hometown == town)
                .ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }     
        }
    }
}
