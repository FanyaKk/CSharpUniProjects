﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Students2._0
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

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string town = studentInfo[3];


                if (IsExistingStudent(students, firstName, lastName))
                {
                    //Student existingStudent = new Student();

                    foreach (var student in students)
                    {
                        if (student.FirstName == firstName && student.LastName == lastName)
                        {
                            //existingStudent = student;
                            student.Age = age;
                            student.Hometown = town;
                        }   
                    }
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = town
                    };
                    students.Add(student);
                }
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

        static bool IsExistingStudent(List<Student>students, string firstName, string LastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == LastName)
                {
                    return true;
                }
            }
            return false;
        }

        //    List<Student> students = new List<Student>();

        //    string command;

        //    while ((command = Console.ReadLine()) != "end")
        //    {
        //        string[] token = command.Split();
              
        //        string firstName = token[0];
        //        string lastName = token[1];
        //        int age = int.Parse(token[2]);
        //        string hometown = token[3];
                

        //        if (IsStudentExisting(students, firstName, lastName))
        //        {
        //            Student student = GetStudents(students, firstName, lastName);

        //            student.Age = age;
        //            student.Hometown = hometown;
        //            //Student existingStudent = new Student();

        //            //foreach (Student student in students)
        //            //{
        //            //    if (student.FirstName == firstName && student.LastName == lastName)
        //            //    {
        //            //        existingStudent = student;
        //            //        existingStudent.Age = age;
        //            //        existingStudent.Hometown = hometown;
        //            //    }
        //            //}
        //        }
        //        else
        //        {
        //            Student student = new Student()
        //            {
        //                FirstName = firstName,
        //                LastName = lastName,
        //                Age = age,
        //                Hometown = hometown
        //            };
        //            students.Add(student);

        //        }        
        //    }
        //    string town = Console.ReadLine();

        //    List<Student> filteredStudents = students
        //        .Where(s => s.Hometown == town)
        //        .ToList();

        //    foreach (var student in filteredStudents)
        //    {
        //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        //    }
        //}
        //static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        //{
        //    foreach (Student student in students)
        //    {
        //        if (student.FirstName == firstName && student.LastName == lastName)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        //static Student GetStudents(List<Student> students, string firstName, string lastName)
        //{
        //    Student existingStudents = null;

        //    foreach (Student student in students)
        //    {
        //        if (student.FirstName == firstName && student.LastName == lastName)
        //        {
        //            existingStudents = student;
        //        }
        //    }
        //    return existingStudents;
        //}
    }
}
