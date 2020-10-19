using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthHall = double.Parse(Console.ReadLine());
            double heightHall = double.Parse(Console.ReadLine());

            widthHall *= 100;
            heightHall = (heightHall * 100) - 100;


            double columns = Math.Floor(widthHall / 120);
            double rows = Math.Floor(heightHall / 70);


            double workStation = (rows * columns) - 3;

            Console.WriteLine(workStation);

        }
    }
}
