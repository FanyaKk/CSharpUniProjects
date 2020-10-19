using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameTurns = int.Parse(Console.ReadLine());

            double result = 0;

            double firstInterval = 0;
            double secondInterval = 0;
            double thirdInterval = 0;
            double fourthInterval = 0;
            double fifthInterval = 0;
            double sixthInterval = 0;


            for (int i = 0; i < gameTurns; i++)
            {
                int turnNumber = int.Parse(Console.ReadLine());

                if (turnNumber >= 0 && turnNumber <= 50)
                {
                    if (turnNumber <= 9)
                    {
                        result = result + (turnNumber * 0.2);
                        firstInterval++;
                    }
                    else if (turnNumber <= 19)
                    {
                        result = result + (turnNumber * 0.3);
                        secondInterval++;
                    }
                    else if (turnNumber <= 29)
                    {
                        result = result + (turnNumber * 0.4);
                        thirdInterval++;
                    }
                    else if (turnNumber <= 39)
                    {
                        result += 50;
                        fourthInterval++;
                    }
                    else if (turnNumber <= 50)
                    {
                        result += 100;
                        fifthInterval++;
                    }
                }
                else
                {
                    result /= 2;
                    sixthInterval++;
                }
            }
            double firstP = firstInterval / gameTurns * 100;
            double secondP = secondInterval / gameTurns * 100;
            double thirdP = thirdInterval / gameTurns * 100;
            double fourthP = fourthInterval / gameTurns * 100;
            double fifthP = fifthInterval / gameTurns * 100;
            double sixthP = sixthInterval / gameTurns * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {firstP:f2}%");
            Console.WriteLine($"From 10 to 19: {secondP:f2}%");
            Console.WriteLine($"From 20 to 29: {thirdP:f2}%");
            Console.WriteLine($"From 30 to 39: {fourthP:f2}%");
            Console.WriteLine($"From 40 to 50: {fifthP:f2}%");
            Console.WriteLine($"Invalid numbers: {sixthP:f2}%");
        }
    }
}
