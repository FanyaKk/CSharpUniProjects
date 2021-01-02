using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)         // version 2.0
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> token = new List<int>();

            bool hasChanges = false;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();
                string action = command[0];

                if (action == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, int.Parse(command[1]));
                    hasChanges = true;
                }
                else if (action == "Contains")
                {
                    int value = int.Parse(command[1]);
                    bool containsNumber = numbers.Contains(value);

                    if (containsNumber)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    token = numbers.FindAll(n => n % 2 == 0);
                    Console.WriteLine(string.Join(" ", token));
                    token = new List<int>();
                }
                else if (action == "PrintOdd")
                {
                    token = numbers.FindAll(n => n % 2 != 0);
                    Console.WriteLine(string.Join(" ", token));
                    token = new List<int>();
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    token.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    List<int> filteredNumbers = new List<int>();
                    string condition = command[1];
                    int currNumber = int.Parse(command[2]);

                    if (condition == "<")
                    {
                        filteredNumbers = numbers.Where(n => n < currNumber).ToList();
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }

                    else if (condition == ">")
                    {
                        filteredNumbers = numbers.Where(n => n > currNumber).ToList();
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                    else if (condition == "<=")
                    {
                        filteredNumbers = numbers.Where(n => n <= currNumber).ToList();
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                    else if (condition == ">=")
                    {
                        filteredNumbers = numbers.Where(n => n >= currNumber).ToList();
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                }
            }
            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        //static void Main(string[] args)         // version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    string command = Console.ReadLine();

        //    bool hasChanges = false;

        //    while (command != "end")
        //    {
        //        string[] input = command.Split();

        //        if (input[0] == "Add")
        //        {
        //            AddNumbers(numbers, input);
        //            hasChanges = true;
        //        }
        //        else if (input[0] == "Remove")
        //        {
        //            RemoveNumbers(numbers, input);
        //            hasChanges = true;
        //        }
        //        else if (input[0] == "RemoveAt")
        //        {
        //            RemoveNumberAtIndex(numbers, input);
        //            hasChanges = true;
        //        }
        //        else if (input[0] == "Insert")
        //        {
        //            InsertNumberAtIndex(numbers, input);
        //            hasChanges = true;
        //        }
        //        if (input[0] == "Contains")
        //        {
        //            ContainsNumber(numbers, input);
        //        }
        //        else if (input[0] == "PrintEven")
        //        {
        //            Console.WriteLine(string.Join(" ", PrintEvenNumbers(numbers)));
        //        }
        //        else if (input[0] == "PrintOdd")
        //        {
        //            Console.WriteLine(string.Join(" ", PrintOddNumbers(numbers)));
        //        }
        //        else if (input[0] == "GetSum")
        //        {
        //            GetNumbersSum(numbers);
        //        }
        //        else if (input[0] == "Filter")
        //        {
        //            Console.WriteLine(string.Join(" ", FilteredList(numbers, input)));
        //        }
        //        command = Console.ReadLine();
        //    }
        //    if (hasChanges == true)
        //    {
        //        Console.WriteLine(string.Join(" ", numbers));
        //    }
        //}           
        //static void ContainsNumber(List<int> numbers, string[] input)
        //{
        //    int value = int.Parse(input[1]);
        //    bool hasInsertedNumber = numbers.Contains(value);
        //    if (hasInsertedNumber)
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No such number");
        //    }
        //    //for (int i = 0; i < numbers.Count; i++)
        //    //{

        //    //    if (numbers[i] == value)
        //    //    {
        //    //        Console.WriteLine("Yes");
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("No such number");
        //    //    }
        //    //}
        //}
        //static List<int> PrintEvenNumbers(List<int> numbers)
        //{
        //    List<int> evenNumbers = new List<int>();
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            evenNumbers.Add(numbers[i]);
        //        }
        //    }
        //    return evenNumbers;
        //}
        //static List<int> PrintOddNumbers(List<int> numbers)
        //{
        //    List<int> oddNumbers = new List<int>();
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] % 2 != 0)
        //        {
        //            oddNumbers.Add(numbers[i]);
        //        }
        //    }
        //    return oddNumbers;
        //}
        //static void GetNumbersSum(List<int> numbers)
        //{
        //    int sumNum = numbers.Sum();
        //    Console.WriteLine(sumNum);
        //}
        //static List<int> FilteredList(List<int> filteredNums, string[] input)
        //{
        //    string condition = input[1].ToString();
        //    int number = int.Parse(input[2]);

        //    if (condition == ">")
        //    {
        //        filteredNums = filteredNums.Where(x => x > number).ToList();
        //    }
        //    else if (condition == "<")
        //    {
        //        filteredNums = filteredNums.Where(x => x < number).ToList();
        //    }
        //    else if (condition == ">=")
        //    {
        //        filteredNums = filteredNums.Where(x => x >= number).ToList();
        //    }
        //    else if (condition == "<=")
        //    {
        //        filteredNums = filteredNums.Where(x => x <= number).ToList();
        //    }

        //    return filteredNums;
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
        //    numbers.Insert(secondValue, firstValue);
        //}  
    }
}
//Exercise 7. List Manipulation Advanced
//Next, we are going to implement more complicated list commands, extending the previous task.Again, read a list
//and keep reading commands until you receive "end":

//Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
//PrintEven – print all the even numbers, separated by a space.
//PrintOdd – print all the odd numbers, separated by a space.
//GetSum – print the sum of all the numbers.
//Filter { condition} {number} – print all the numbers that fulfill the given condition.The condition will be either "<", ">", ">=", "<=".
//After the end command, print the list only if you have made some changes to the original list.Changes are made
//only from the commands from the previous task.
//Example

//Input                      |     Output
//                           |
//2 13 43 876 342 23 543     |     No such number
//Contains 100               |     Yes
//Contains 543               |     2 876 342
//PrintEven                  |     13 43 23 543
//PrintOdd                   |     1842
//GetSum                     |     43 876 342 543
//Filter >= 43               |     2 13 43 23
//Filter < 100               |
//end                        |
