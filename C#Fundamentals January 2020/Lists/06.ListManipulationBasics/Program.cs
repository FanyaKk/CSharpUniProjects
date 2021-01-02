using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)              //version 2.0
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                string action = command[0];
                int value = int.Parse(command[1]);
                if (action == "Add")
                {
                    numbers.Add(value);
                }
                else if (action == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (action == "RemoveAt")
                {
                    numbers.RemoveAt(value);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        //static void Main(string[] args)           //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    string command = Console.ReadLine();

        //    while (command != "end")
        //    {
        //        string[] input = command.Split();

        //        if (input[0] == "Add")
        //        {
        //            AddNumbers(numbers, input);
        //        }
        //        else if (input[0] == "Remove")
        //        {
        //            RemoveNumbers(numbers, input);
        //        }
        //        else if (input[0] == "RemoveAt")
        //        {
        //            RemoveNumberAtIndex(numbers, input);
        //        }
        //        else if (input[0] == "Insert")
        //        {
        //            InsertNumberAtIndex(numbers, input);
        //        }

        //        command = Console.ReadLine();
        //    }
        //    Console.WriteLine(string.Join(" ",numbers));
        //}
        //static void AddNumbers(List<int> numbers, string[] input)
        //{
        //    int value = int.Parse(input[1]);
        //    numbers.Add(value);
        //}
        //static void RemoveNumbers(List<int> numbers, string[] input)
        //{
        //    int value = int.Parse(input[1]);
        //    numbers.Remove(value);
        //}
        //static void RemoveNumberAtIndex(List<int> numbers, string[] input)
        //{
        //    int value = int.Parse(input[1]);
        //    numbers.RemoveAt(value);
        //}
        //static void InsertNumberAtIndex(List<int> numbers, string[] input)
        //{
        //    int firstValue = int.Parse(input[1]);
        //    int secondValue = int.Parse(input[2]);
        //    numbers.Insert(secondValue, firstValue );
        //}
    }
}
//Exercise 6. List Manipulation Basics
//Write a program that reads a list of integers.Then until you receive end, you will receive different commands:
//Add {number}: add a number to the end of the list.
//Remove {number}: remove a number from the list.
//RemoveAt
//{ index }: remove a number at a given index.
//Insert {number} {index}: insert a number at a given index.
//Note: All the indices will be valid!
//When you receive the "end" command, print the final state of the list(separated by spaces).

//Example
//Input                 Output
//4 19 2 53 6 43        4 53 6 8 43 3
//Add 3
//Remove 2
//RemoveAt 1
//Insert 8 3
//end

