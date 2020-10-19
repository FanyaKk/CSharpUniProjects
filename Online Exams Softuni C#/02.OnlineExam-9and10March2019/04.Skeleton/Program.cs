using System;

namespace _04.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int secounds = int.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            int secoundFor100Meters = int.Parse(Console.ReadLine());

            int passcheckInSecounds = (minutes * 60) + secounds;
            double reducingTime = meters / 120 * 2.5;

            double newTime = secoundFor100Meters * (meters / 100) - reducingTime;

            if (newTime <= passcheckInSecounds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {newTime:f3}.");
            }
            else
            {
                double secoundMore = newTime - passcheckInSecounds;
                Console.WriteLine($"No, Marin failed! He was {secoundMore:f3} second slower.");
            }
        }
    }
}
