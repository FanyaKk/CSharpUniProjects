using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsInFirstSector = int.Parse(Console.ReadLine());
            int placesInOddRow = int.Parse(Console.ReadLine());

            int places = 0;
            char i = ' ';
            int numberOfPlaces = 0;

            for (i = 'A'; i <= lastSector; i++)
            {
                if (i != 'A')
                {
                    rowsInFirstSector += 1;
                }
                for (int j = 1; j <= rowsInFirstSector; j++)
                {
                    if (j % 2 == 0)
                    {
                        places = placesInOddRow + 2;
                    }
                    else if (j % 2 != 0)
                    {
                        places = placesInOddRow;
                    }
                    for (int k = 97; k < places+97; k++)
                    {

                        Console.WriteLine($"{i}{j}{(char)k}");
                        numberOfPlaces++;
                    }
                }
                places = placesInOddRow;
            }
            Console.WriteLine(numberOfPlaces);
        }
    }
}
