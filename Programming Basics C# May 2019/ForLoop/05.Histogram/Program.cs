using System;

namespace _05.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            int firstCount = 0;
            int secondCount = 0;
            int thirdCount = 0;
            int fourthCount = 0;
            int fifthCount = 0;

            double firstP = 0;
            double secondP = 0;
            double thirdP = 0;
            double fourthP = 0;
            double fifthP = 0;

            for (int i = 0; i < numbers; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                if (nextNumber < 200)
                {
                    firstCount++;
                }
                else if (nextNumber < 400)
                {
                    secondCount++;
                }
                else if (nextNumber < 600)
                {
                    thirdCount++;
                }
                else if (nextNumber < 800)
                {
                    fourthCount++;
                }
                else if (nextNumber <= 1000)
                {
                    fifthCount++;
                }
            }
           
            firstP = firstCount / numbers * 100;
            secondP = secondCount / numbers * 100;
            thirdP = thirdCount / numbers * 100;
            fourthP = fourthCount / numbers * 100;
            fifthP = fifthCount / numbers * 100;

            Console.WriteLine($"{firstP:f2}%");
            Console.WriteLine($"{secondP:f2}%");
            Console.WriteLine($"{thirdP:f2}%");
            Console.WriteLine($"{fourthP:f2}%");
            Console.WriteLine($"{fifthP:f2}%");
        }
    }
}
