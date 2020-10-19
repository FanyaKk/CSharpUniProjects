using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            bool isEqual = false;

            firstNumber /= 0.000001;
            secondNumber /= 0.000001;

            int firstForCompare = (int)firstNumber;
            int secondForCompare = (int)secondNumber;

            if (firstForCompare == secondForCompare)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}
