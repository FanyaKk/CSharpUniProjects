using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> input = command.Split().ToList();
                if(input[0] == "Delete")
                {
                    int delNumber = int.Parse(input[1]);
                    RemoveAll(numbers, delNumber);
                }
                if(input[0] == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void RemoveAll(List<int> numbers, int delNumber)
        {           
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == delNumber)
                {
                    numbers.Remove(delNumber);
                }
            }
        }
    }
}
