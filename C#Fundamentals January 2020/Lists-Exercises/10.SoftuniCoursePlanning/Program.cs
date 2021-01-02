using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseShedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] command = input.Split(":");

                string lessonTitle = command[1];

                if (command[0] == "Add")
                {
                    if (!courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Add(lessonTitle);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    if (!courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Insert(index, lessonTitle);
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Remove(lessonTitle);
                    }
                    if (courseShedule.Contains(lessonTitle + "-Exercise"))
                    {
                        courseShedule.Remove(lessonTitle + "-Exercise");
                    }
                }
                else if (command[0] == "Swap")
                {
                    string exerciseTitle = command[2];
                    if (courseShedule.Contains(exerciseTitle) && courseShedule.Contains(lessonTitle))
                    {
                        int lessonIndex = courseShedule.IndexOf(lessonTitle);
                        int exerciseIndex = courseShedule.IndexOf(exerciseTitle);
                        courseShedule.Insert(lessonIndex, exerciseTitle);
                        courseShedule.RemoveAt(lessonIndex + 1);
                        courseShedule.Insert(exerciseIndex, lessonTitle);
                        courseShedule.RemoveAt(exerciseIndex + 1);
                        if (courseShedule.Contains(lessonTitle + "-Exercise"))
                        {
                            courseShedule.Remove(lessonTitle + "-Exercise");
                            courseShedule.Insert(exerciseIndex + 1, lessonTitle + "-Exercise");
                        }
                        if (courseShedule.Contains(exerciseTitle + "-Exercise"))
                        {
                            courseShedule.Remove(exerciseTitle + "-Exercise");
                            courseShedule.Insert(lessonIndex + 1, exerciseTitle + "-Exercise");
                        }
                    }   
                }
                else if (command[0] == "Exercise")
                {
                    if (courseShedule.Contains(lessonTitle)&&!courseShedule.Contains(lessonTitle + "-Exercise"))
                    {
                        int indexOfLesson = courseShedule.IndexOf(lessonTitle);
                        courseShedule.Insert(indexOfLesson + 1, lessonTitle + "-Exercise");
                    }
                    else if (!courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Add(lessonTitle);
                        courseShedule.Add(lessonTitle + "-Exercise");
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < courseShedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courseShedule[i]}");
            }
        }
    }
}
//10. * SoftUni Course Planning

//You are tasked to help with the planning of the next Technology Fundamentals course by keeping track of the
//lessons, that are going to be included in the course, as well as all the exercises for the lessons.
//On the first line you will receive the initial schedule of the lessons and the exercises that are going to be a part of
//the next course, separated by comma and space ", ". But before the course starts, some changes should be made.
//Until you receive "course start" you will be given some commands to modify the course schedule.The possible
//commands are:

//Add:{lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
//Insert:{ lessonTitle}:{index} – insert the lesson to the given index, if it does not exist.
//Remove:{ lessonTitle} – remove the lesson, if it exists.
//Swap:{ lessonTitle}:{lessonTitle} – change the place of the two lessons, if they exist.
//Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index, if the lesson exists and there
//is no exercise already, in the following format "{lessonTitle}-Exercise".
//If the lesson doesn`t exist, add the
//lesson in the end of the course schedule, followed by the Exercise.

//Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow
//the lessons.

//Input / Constraints
// first line – the initial schedule lessons – strings, separated by comma and space ", "
// until "course start" you will receive commands in the format described above

//Output
// Print the whole course schedule, each lesson on a new line with its number(index) in the schedule:
//"{lesson index}.{lessonTitle}"
// Allowed working time / memory: 100ms / 16MB.

//Examples:
//Input               |  Output         |     Comment
//-----------------------------------------------------------------------------------------------
//Data Types,         |  1.Arrays       |     We receive the initial schedule.
//Objects, Lists      |  2.Data Types   |     Next, we add Databases lesson, because it
//Add:Databases       |  3.Objects      |     doesn`t exist.
//Insert:Arrays:0     |  4.Databases    |     We Insert at the given index lesson Arrays,
//Remove:Lists        |                 |     because its not present in the schedule.
//course start        |                 |     After receiving the last command and removing
//                    |                 |     lesson Lists, we print the whole schedule.
//-----------------------------------------------------------------------------------------------
//Arrays, Lists,      |  1.Methods      |     We swap the given lessons, because both exist.
//Methods             |  2.Databases    |     After receiving the Exercise command, we see
//Swap:Arrays:Methods |  3.Databases-   |     that such lesson doesn`t exist, so we add the
//Exercise:Databases  |  Exercise       |     lesson at the end, followed by the exercise.
//Swap:Lists:Database |  4.Arrays       |     We swap Lists and Databases lessons, the
//s                   |  5.Lists        |     Databases-Exercise is also moved after the
//Insert:Arrays:0     |                 |     Databases lesson.
//course start        |                 |     We skip the next command, because we already
//                    |                 |     have such lesson in our schedule.