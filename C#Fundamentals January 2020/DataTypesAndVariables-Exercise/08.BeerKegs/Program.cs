using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggerKeg = 0;
            string bestModel = "";

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (biggerKeg < volume)
                {
                    biggerKeg = volume;
                    bestModel = model;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
