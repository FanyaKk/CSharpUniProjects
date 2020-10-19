using System;

namespace _08.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;

            for (int hours = 0; hours < 24; hours++) 
            {
                if (hours == 23)
                {
                    minutes++;
                }
                Console.WriteLine($"{hours} : 0");

                for (minutes = 1; minutes < 60; minutes++)
                {
                    Console.WriteLine($"{hours} : {minutes}");
                }
            }
        }
    }
}
