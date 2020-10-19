using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }
        static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if(HasOddNumber(i) && IsDevisibleTo8(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool HasOddNumber(int number)
        {
            int digit = 0;
            while (number > 0)
            { 
                digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsDevisibleTo8(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }
            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
