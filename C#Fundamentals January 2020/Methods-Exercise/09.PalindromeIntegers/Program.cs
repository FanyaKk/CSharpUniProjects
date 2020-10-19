using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                Console.WriteLine(IsPallindromeNumber(number).ToString().ToLower());

                number = Console.ReadLine();
            }
        }
        static bool IsPallindromeNumber(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
