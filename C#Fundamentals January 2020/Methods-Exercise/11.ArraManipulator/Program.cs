using System;
using System.Linq;

namespace _11.ArraManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                int exchangeIndex = 0;
                string[] command = input.Split();

                if (command[0] == "exchange")
                {
                    exchangeIndex = int.Parse(command[1]);
                    if (exchangeIndex < 0 || exchangeIndex >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeNumber(numbers, exchangeIndex);
                    }
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        IndexOfMaxEvenOddNumberInArray(numbers, input);
                    }
                    else if (command[1] == "odd")
                    {
                        IndexOfMaxEvenOddNumberInArray(numbers, input);
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        IndexOfMinEvenOddNumberInArray(numbers, input);
                    }
                    else if (command[1] == "odd")
                    {
                        IndexOfMinEvenOddNumberInArray(numbers, input);
                    }
                }
                input = Console.ReadLine();
            }
        }
        static void ExchangeNumber(int[] numbers, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                int temp = numbers[0];
                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length - 1] = temp;
            }
        }
        static void IndexOfMaxEvenOddNumberInArray(int[] numbers, string command)
        {
            int index = 0;
            int maxEvenOddNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (command=="odd" && numbers[i] % 2 != 0)
                {
                    if (maxEvenOddNumber < numbers[i])
                    {
                        maxEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
                if (command == "even" && numbers[i] % 2 == 0)
                {
                    if (maxEvenOddNumber < numbers[i])
                    {
                        maxEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
            }
        }
        static void IndexOfMinEvenOddNumberInArray(int[] numbers, string command)
        {
            int index = 0;
            int minEvenOddNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (command == "even" && numbers[i] % 2 == 0)
                {
                    if (minEvenOddNumber > numbers[i])
                    {
                        minEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
                if (command == "odd" && numbers[i] % 2 != 0)
                {
                    if (minEvenOddNumber > numbers[i])
                    {
                        minEvenOddNumber = numbers[i];
                        index = i;
                    }
                }
            }
        }
    }
}
