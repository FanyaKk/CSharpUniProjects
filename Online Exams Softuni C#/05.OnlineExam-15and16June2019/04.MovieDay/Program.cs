using System;

namespace _04.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int photosTime = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            double sceneTime = double.Parse(Console.ReadLine());

            double preparations = photosTime * 0.15;
            double captureTime = scenesCount * sceneTime;
            double leftPhotosTime = photosTime - preparations;

            double leftTime = Math.Round(Math.Abs(leftPhotosTime - captureTime));

            if (leftPhotosTime >= captureTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {leftTime} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {leftTime} minutes.");
            }
            
        }
    }
}
