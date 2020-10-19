using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            char operationType = char.Parse(Console.ReadLine());

            double result = 0;
            string numberType = "";

            if (operationType == '+' || operationType == '-' || operationType == '*')
            {
                if (operationType == '+')
                {
                    result = firstNumber + secondNumber;
                }
                else if (operationType == '-')
                { 
                    result = firstNumber - secondNumber; 
                }
                else if (operationType == '*')
                {
                    result = firstNumber * secondNumber;
                }
                if (result % 2 == 0)
                {
                    numberType = "even";
                }
                else if (result % 2 != 0)
                {
                    numberType = "odd";
                }
            }
            //else if (operationType == '-')
            //{
            //    result = firstNumber - secondNumber;
            //    if (result % 2 == 0)
            //    {
            //        numberType = "even";
            //    }
            //    else
            //    {
            //        numberType = "odd";
            //    }
            //}
            //else if (operationType == '*')
            //{
            //    result = firstNumber * secondNumber;
            //    if (result % 2 == 0)
            //    {
            //        numberType = "even";
            //    }
            //    else
            //    {
            //        numberType = "odd";
            //    }
            //}
            else if (operationType == '/')
            {
                result = firstNumber / secondNumber;
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                }
            }
            else if (operationType == '%')
            {
                result = firstNumber % secondNumber;
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
            }
            if (operationType == '+' || operationType == '-' || operationType == '*')
            {
                Console.WriteLine($"{firstNumber} {operationType} {secondNumber} = {result} - {numberType}");
            }
        }
    }
}
