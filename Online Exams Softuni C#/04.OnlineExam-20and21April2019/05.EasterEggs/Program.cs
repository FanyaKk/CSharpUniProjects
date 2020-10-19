using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxCount = 0;
            string maxColour = "";

            for (int i = 0; i < eggsCount; i++)
            {
                string eggColour = Console.ReadLine();

                if (eggColour == "red")
                {
                    redEggs++;
                }
                else if (eggColour == "orange")
                {
                    orangeEggs++;
                }
                else if (eggColour == "blue")
                {
                    blueEggs++;
                }
                else if (eggColour == "green")
                {
                    greenEggs++;
                }
            }
            if (maxCount < redEggs)
            {
                maxCount = redEggs;
                maxColour = "red";
            }
            if (maxCount < orangeEggs)
            {
                maxCount = orangeEggs;
                maxColour = "orange";
            }
            if (maxCount < blueEggs)
            {
                maxCount = blueEggs;
                maxColour = "blue";
            }
            if (maxCount < greenEggs)
            {
                maxCount = greenEggs;
                maxColour = "green";
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxCount} -> {maxColour}");
        }
    }
}
