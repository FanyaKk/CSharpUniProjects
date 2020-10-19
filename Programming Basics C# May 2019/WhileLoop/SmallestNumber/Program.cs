using System;

namespace SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int smallestNumber = int.MaxValue;

            while (number > 0)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                number--;

                if(smallestNumber > nextNumber)
                {
                    smallestNumber = nextNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
