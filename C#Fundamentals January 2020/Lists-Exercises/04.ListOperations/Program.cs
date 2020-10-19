using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            while((command = Console.ReadLine()) != "End")
            {
                List<string> input = command.Split().ToList();

                string action = input[0];

                if (action == "Add")
                {
                    int number = int.Parse(input[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    InsertNumber(numbers, index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(input[1]);
                    DeleteNumber(numbers, index);
                }
                else if (action == "Shift")
                {
                    string direction = input[1];
                    int count = int.Parse(input[2]);
                    ShiftLeftRight(numbers, count, direction);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void InsertNumber(List<int> numbers, int index, int number)
        {
            if (index >= 0 && index < numbers.Count)
            {
                numbers.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        static void DeleteNumber(List<int> numbers, int index)
        {
            if (index >= 0 && index < numbers.Count)
            {
                numbers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        static void ShiftLeftRight(List<int> numbers, int count, string direction )
        {
            count = count % numbers.Count;
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}