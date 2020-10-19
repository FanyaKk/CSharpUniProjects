using System;

namespace _02.SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageLengthAstonauts = double.Parse(Console.ReadLine());

            double shipVolume = width * height * length;
            double roomSize = 2 * 2 * (averageLengthAstonauts + 0.4);

            double numberOfAstronauts = Math.Floor(shipVolume / roomSize);

            if(numberOfAstronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (numberOfAstronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {numberOfAstronauts} astronauts.");
            }
            else if (numberOfAstronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
