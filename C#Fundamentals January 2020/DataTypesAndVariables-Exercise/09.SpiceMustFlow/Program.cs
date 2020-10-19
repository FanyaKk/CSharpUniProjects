using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalSpices = 0;
            int dayCounter = 0;


            while (startingYield >= 100)
            {
                dayCounter++;
                totalSpices += startingYield - 26;
                startingYield -= 10;

            }
            if (totalSpices >= 26)
            {
                totalSpices -= 26;
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalSpices);
        }
    }
}
