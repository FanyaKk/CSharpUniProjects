using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            double workDays = 365 - holidays;
            double workDayPlaying = workDays * 63;
            double holidayPlaying = holidays * 127;

            double totalTimePlaying = workDayPlaying + holidayPlaying;
            double catTimeForPlaying = 30000;

            double overPlayingMinutes = Math.Abs(totalTimePlaying - catTimeForPlaying);
            double hours = Math.Floor(overPlayingMinutes / 60);
            double minutes = overPlayingMinutes % 60;

            if (catTimeForPlaying < totalTimePlaying)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
