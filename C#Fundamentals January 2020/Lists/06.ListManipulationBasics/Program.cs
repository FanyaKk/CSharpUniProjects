using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();

                if (input[0] == "Add")
                {
                    AddNumbers(numbers, input);
                }
                else if (input[0] == "Remove")
                {
                    RemoveNumbers(numbers, input);
                }
                else if (input[0] == "RemoveAt")
                {
                    RemoveNumberAtIndex(numbers, input);
                }
                else if (input[0] == "Insert")
                {
                    InsertNumberAtIndex(numbers, input);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static void AddNumbers(List<int> numbers, string[] input)
        {
            int value = int.Parse(input[1]);
            numbers.Add(value);
        }
        static void RemoveNumbers(List<int> numbers, string[] input)
        {
            int value = int.Parse(input[1]);
            numbers.Remove(value);
        }
        static void RemoveNumberAtIndex(List<int> numbers, string[] input)
        {
            int value = int.Parse(input[1]);
            numbers.RemoveAt(value);
        }
        static void InsertNumberAtIndex(List<int> numbers, string[] input)
        {
            int firstValue = int.Parse(input[1]);
            int secondValue = int.Parse(input[2]);
            numbers.Insert(secondValue, firstValue );
        }
    }
}
