using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePieces = length * width;

            int takenPieces = 0;
            int eatenPieces = 0;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                takenPieces = int.Parse(command);
                eatenPieces += takenPieces;

                if (eatenPieces >= cakePieces)
                {
                    cakePieces -= eatenPieces;
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                cakePieces -= eatenPieces;
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
        }
    }
}
