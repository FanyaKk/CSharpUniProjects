using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> courses = new Dictionary<string, int>();
            SortedDictionary<string, string> studentsNames = new SortedDictionary<string, string>();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" : ").ToArray();

                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = 0;
                }
                courses[courseName]++;
                studentsNames[studentName] = courseName;
            }
            courses = courses
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
                
                foreach (var student in studentsNames)
                {
                    if (course.Key == student.Value)
                    {
                        Console.WriteLine($"-- {student.Key}");
                    }   
                }
            }
        }
    }
}
