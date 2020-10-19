using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            bool hasChanges = false;

            while (command != "end")
            {
                string[] input = command.Split();

                if (input[0] == "Add")
                {
                    AddNumbers(numbers, input);
                    hasChanges = true;
                }
                else if (input[0] == "Remove")
                {
                    RemoveNumbers(numbers, input);
                    hasChanges = true;
                }
                else if (input[0] == "RemoveAt")
                {
                    RemoveNumberAtIndex(numbers, input);
                    hasChanges = true;
                }
                else if (input[0] == "Insert")
                {
                    InsertNumberAtIndex(numbers, input);
                    hasChanges = true;
                }
                if (input[0] == "Contains")
                {
                    ContainsNumber(numbers, input);
                }
                else if (input[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", PrintEvenNumbers(numbers)));
                }
                else if (input[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", PrintOddNumbers(numbers)));
                }
                else if (input[0] == "GetSum")
                {
                    GetNumbersSum(numbers);
                }
                else if (input[0] == "Filter")
                {
                    Console.WriteLine(string.Join(" ", FilteredList(numbers, input)));
                }
                command = Console.ReadLine();
            }
            if (hasChanges == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static void ContainsNumber(List<int> numbers, string[] input)
        {
            int value = int.Parse(input[1]);
            bool hasInsertedNumber = numbers.Contains(value);
            if (hasInsertedNumber)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    if (numbers[i] == value)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No such number");
            //    }
            //}
        }
        static List<int> PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            return evenNumbers;
        }
        static List<int> PrintOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            return oddNumbers;
        }
        static void GetNumbersSum(List<int> numbers)
        {
            int sumNum = numbers.Sum();
            Console.WriteLine(sumNum);
        }
        static List<int> FilteredList(List<int> filteredNums, string[] input)
        {
            string condition = input[1].ToString();
            int number = int.Parse(input[2]);

            if (condition == ">")
            {
                filteredNums = filteredNums.Where(x => x > number).ToList();
            }
            else if (condition == "<")
            {
                filteredNums = filteredNums.Where(x => x < number).ToList();
            }
            else if (condition == ">=")
            {
                filteredNums = filteredNums.Where(x => x >= number).ToList();
            }
            else if (condition == "<=")
            {
                filteredNums = filteredNums.Where(x => x <= number).ToList();
            }

            return filteredNums;
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
            numbers.Insert(secondValue, firstValue);
        }
    }
}
