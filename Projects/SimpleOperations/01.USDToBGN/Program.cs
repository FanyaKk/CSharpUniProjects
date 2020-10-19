using System;

namespace _01.USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double toBGN = Math.Round(usd * 1.79549, 2);

            Console.WriteLine(toBGN);
        }
    }
}
