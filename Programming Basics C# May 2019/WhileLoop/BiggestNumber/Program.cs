using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            while (number > 0)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                number--;
                if (biggestNumber < nextNumber)
                {
                    biggestNumber = nextNumber;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
