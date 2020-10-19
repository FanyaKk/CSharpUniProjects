using System;

namespace _09.ClockPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            int seconds = 0;

            for (int hours = 0; hours < 24; hours++)
            {
                if(hours == 23)
                {
                    minutes++;
                }
                for (minutes = 0; minutes < 60; minutes++)
                {
                    if (minutes == 59)
                    {
                        seconds++;
                    }
                    Console.WriteLine($"{hours} : {minutes} : 0");
                    for (seconds = 1; seconds < 60; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                }
            }
        }
    }
}
