using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)              //version 2.0
        {
            List<int> numbers = Console.ReadLine()
                .Split().
                Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                string command = input[0];
                int number = int.Parse(input[1]);

                if (command == "Delete")
                {                   
                    numbers = numbers.FindAll(n => n != number).ToList();
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, number);
                }
                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        //static void Main(string[] args)           //version 1.0
        //{
        //    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        //    string command = "";
        //    while ((command = Console.ReadLine()) != "end")
        //    {
        //        List<string> input = command.Split().ToList();
        //        if(input[0] == "Delete")
        //        {
        //            int delNumber = int.Parse(input[1]);
        //            RemoveAll(numbers, delNumber);
        //        }
        //        if(input[0] == "Insert")
        //        {
        //            int number = int.Parse(input[1]);
        //            int index = int.Parse(input[2]);
        //            numbers.Insert(index, number);
        //        }
        //    }
        //    Console.WriteLine(string.Join(" ", numbers));
        //}
        //static void RemoveAll(List<int> numbers, int delNumber)
        //{           
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] == delNumber)
        //        {
        //            numbers.Remove(delNumber);
        //        }
        //    }
        //}
    }
}
//Exercise 2. Change List

//Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
//Your program may receive the following commands:

// Delete {element} – delete all elements in the array, which are equal to the given element.
// Insert { element} {position} – insert an element and the given position.

//You should stop the program when you receive the command &quot;end&quot;. Print the numbers in the array separated by a
//single whitespace.

//Examples

//Input                            |     Output
//--------------------------------------------------------------------------                                   
//1 2 3 4 5 5 5 6                  |     1 10 2 3 4 6
//Delete 5                         |
//Insert 10 1                      |
//Delete 5                         |
//end                              |
//--------------------------------------------------------------------------         
//20 12 4 319 21 31234 2 41 23 4   |     20 12 50 319 50 21 31234 2 41 23
//Insert 50 2                      |
//Insert 50 5                      |
//Delete 4                         |
//end                              |