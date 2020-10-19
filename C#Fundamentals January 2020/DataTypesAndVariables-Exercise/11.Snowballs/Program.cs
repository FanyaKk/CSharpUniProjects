using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            BigInteger highestSnowballSnow = 0;
            BigInteger highestSnowballTime = 0;
            BigInteger highestSnowballQuality = 0;

            for (BigInteger i = 0; i < input; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, (int)snowballQuality);

                if (highestValue < snowballValue)
                {
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                    highestValue = snowballValue;
                }
            }
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestValue} ({highestSnowballQuality})");
        }
    }
}
