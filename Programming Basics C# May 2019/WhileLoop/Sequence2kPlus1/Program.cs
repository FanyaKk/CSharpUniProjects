using System;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double sumNumber = 1;

            while (sumNumber <= number)
            {
                Console.WriteLine(sumNumber);
                sumNumber = (sumNumber * 2) + 1;
            }
        }
    }
}
