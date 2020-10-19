using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (!(number == 0 || 100 <= number && number <= 200))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
