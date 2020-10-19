using System;

namespace _03.Logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());

            int busPrice = 0;
            int truckPrice = 0;
            int trainPrice = 0;

            double averagePrice = 0;
            double totalTones = 0;

            double busPercent = 0;
            double truckPercent = 0;
            double trainPercent = 0;

            int busTones = 0;
            int truckTones = 0;
            int trainTones = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int tones = int.Parse(Console.ReadLine());

                if (tones <= 3)
                {
                    busPrice += tones * 200;
                    busTones += tones;
                }
                else if (tones <= 11)
                {
                    truckPrice += tones * 175;
                    truckTones += tones;

                }
                else if (tones >= 12)
                {
                    trainPrice += tones * 120;
                    trainTones += tones;
                }
                totalTones += tones;

            }
            averagePrice = (busPrice + truckPrice + trainPrice) / totalTones;
            busPercent = busTones / totalTones * 100;
            truckPercent = truckTones / totalTones * 100;
            trainPercent = trainTones / totalTones * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
