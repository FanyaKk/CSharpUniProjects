using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine()); //in meters
            double hallWidth = double.Parse(Console.ReadLine()); //in meters
            double wardrobeSide = double.Parse(Console.ReadLine()); //in meters

            double hallSize = hallLength * hallWidth;
            double wardrobeSize = wardrobeSide * wardrobeSide;
            double benchSize = hallSize / 10;

            double totalHallSize = hallSize - wardrobeSize - benchSize; //in meters

            double dancersCount = totalHallSize / 0.7040;

            Console.WriteLine(Math.Floor(dancersCount));
        }
    }
}
