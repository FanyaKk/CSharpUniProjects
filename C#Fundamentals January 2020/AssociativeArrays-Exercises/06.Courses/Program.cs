using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)                     //version 2.0
        {
            string input = string.Empty;

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ").ToArray();

                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);
            }
            courses = courses
                .OrderByDescending(v => v.Value.Count)
                .ToDictionary(k=>k.Key, v => (List<string>)v.Value.OrderBy(v=>v).ToList()); //To Dictionary with sorting list by name in ascending order

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", course.Value)}");
            }
        }
        //static void Main(string[] args)                   //version 1.0
        //{
        //    Dictionary<string, int> courses = new Dictionary<string, int>();
        //    SortedDictionary<string, string> studentsNames = new SortedDictionary<string, string>();

        //    string command = "";

        //    while ((command = Console.ReadLine()) != "end")
        //    {
        //        string[] input = command.Split(" : ").ToArray();

        //        string courseName = input[0];
        //        string studentName = input[1];

        //        if (!courses.ContainsKey(courseName))
        //        {
        //            courses[courseName] = 0;
        //        }
        //        courses[courseName]++;
        //        studentsNames[studentName] = courseName;
        //    }
        //    courses = courses
        //        .OrderByDescending(kvp => kvp.Value)
        //        .ToDictionary(a => a.Key, b => b.Value);

        //    foreach (var course in courses)
        //    {
        //        Console.WriteLine($"{course.Key}: {course.Value}");
                
        //        foreach (var student in studentsNames)
        //        {
        //            if (course.Key == student.Value)
        //            {
        //                Console.WriteLine($"-- {student.Key}");
        //            }   
        //        }
        //    }
        //}
    }
}
//6. Courses
//Write a program that keeps information about courses.Each course has a name and registered students.
//You will be receiving a course name and a student name, until you receive the command "end". Check if such
//course already exists, and if not, add the course. Register the user into the course. When you receive the command
//"end", print the courses with their names and total registered users, ordered by the count of registered users in
//descending order. For each contest print the registered users ordered by name in ascending order.

//Input

// Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
// The product data is always delimited by " : ".

//Output
// Print the information about each course in the following the format:
//"{courseName}: {registeredStudents}"
// Print the information about each student, in the following the format:
//"-- {studentName}"
//Examples

//Input                                                     Output

//Programming Fundamentals : John Smith                     Programming Fundamentals: 2
//Programming Fundamentals : Linda Johnson                  -- John Smith
//JS Core : Will Wilson                                     -- Linda Johnson
//Java Advanced : Harrison White                            JS Core: 1
//end                                                       -- Will Wilson
//                                                          Java Advanced: 1
//                                                          -- Harrison White

//Algorithms : Jay Moore                                    Python Fundamentals: 3
//Programming Basics : Martin Taylor                        -- Andrew Robinson
//Python Fundamentals : John Anderson                       -- Clark Lewis
//Python Fundamentals : Andrew Robinson                     -- John Anderson
//Algorithms : Bob Jackson                                  Algorithms: 2
//Python Fundamentals : Clark Lewis                         -- Bob Jackson
//end                                                       -- Jay Moore
//                                                          Programming Basics: 1
//                                                          -- Martin Taylor
//