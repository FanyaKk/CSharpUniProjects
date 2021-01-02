using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string action = command[0];

                if (action == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }  
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }  
                }
                else if (action == "Shift")
                {
                    string secondAction = command[1];
                    int index = int.Parse(command[2]);
                    int lastIndex = numbers.Count - 1;

                    if (secondAction == "left")
                    {
                        index = index % numbers.Count;
                        for (int i = 0; i < index; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (secondAction == "right")
                    {
                        index = index % numbers.Count;
                        for (int i = 0; i < index; i++)
                        {
                            numbers.Insert(0, numbers[lastIndex]);
                            numbers.RemoveAt(lastIndex + 1);                //Добавя се защото lastIndex е взето като стойност преди добавянето на последното число на индекс 0 и броя на числата в листа се увеличава с 1
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }         
        //static void Main(string[] args)           //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    string command = "";
        //    while((command = Console.ReadLine()) != "End")
        //    {
        //        List<string> input = command.Split().ToList();

        //        string action = input[0];

        //        if (action == "Add")
        //        {
        //            int number = int.Parse(input[1]);
        //            numbers.Add(number);
        //        }
        //        else if (action == "Insert")
        //        {
        //            int number = int.Parse(input[1]);
        //            int index = int.Parse(input[2]);
        //            InsertNumber(numbers, index, number);
        //        }
        //        else if (action == "Remove")
        //        {
        //            int index = int.Parse(input[1]);
        //            DeleteNumber(numbers, index);
        //        }
        //        else if (action == "Shift")
        //        {
        //            string direction = input[1];
        //            int count = int.Parse(input[2]);
        //            ShiftLeftRight(numbers, count, direction);
        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", numbers));
        //}
        //static void InsertNumber(List<int> numbers, int index, int number)
        //{
        //    if (index >= 0 && index < numbers.Count)
        //    {
        //        numbers.Insert(index, number);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid index");
        //    }
        //}
        //static void DeleteNumber(List<int> numbers, int index)
        //{
        //    if (index >= 0 && index < numbers.Count)
        //    {
        //        numbers.RemoveAt(index);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid index");
        //    }
        //}
        //static void ShiftLeftRight(List<int> numbers, int count, string direction )
        //{
        //    count = count % numbers.Count;
        //    if (direction == "left")
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            numbers.Add(numbers[0]);
        //            numbers.RemoveAt(0);
        //        }
        //    }
        //    else if (direction == "right")
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            numbers.Insert(0, numbers[numbers.Count - 1]);
        //            numbers.RemoveAt(numbers.Count - 1);
        //        }
        //    }
        //}
    }
}
//Exercise 4. List Operations

//You will be given a list of integer numbers on the first line of input.You will be receiving operations you have to
//apply on the list until you receive the "End" command.The possible commands are:

// Add {number} – add number at the end.
// Insert {number} {index} – insert number at given index.
// Remove {index} – remove at index.
// Shift left { count } – first number becomes last ‘count’ times.
// Shift right { count } – last number becomes first ‘count’ times.

//Note: there is a possibility that the given index is outside of the bounds of the array.In that case print "Invalid index"

//Examples

//Input                 |    Output
//----------------------------------------------------
//1 23 29 18 43 21 20   |    43 20 5 1 23 29 18
//Add 5                 |
//Remove 5              |
//Shift left 3          |
//Shift left 1          |
//End                   |
//----------------------------------------------------                      
//5 12 42 95 32 1       |    Invalid index
//Insert 3 0            |    5 12 42 95 32 8 1 3
//Remove 10             |
//Insert 8 6            |
//Shift right 1         |
//Shift left 2          |
//End                   |