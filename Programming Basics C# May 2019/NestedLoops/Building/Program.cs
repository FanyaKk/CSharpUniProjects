using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNumbers = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            // my work
            for (int i = floorNumbers; i <= floorNumbers && i != 0; i--)
            {
                if (i % 2 == 0 && i != floorNumbers)
                {
                    for (int roomNumber = 0; roomNumber < roomsPerFloor; roomNumber++)
                    {
                        Console.Write($"O{i}{roomNumber} ");
                    }
                }
                else if (i == floorNumbers)
                {
                    for (int roomNumber = 0; roomNumber < roomsPerFloor; roomNumber++)
                    {
                        Console.Write($"L{floorNumbers}{roomNumber} ");
                    }
                }
                else
                {
                    for (int roomNumber = 0; roomNumber < roomsPerFloor; roomNumber++)
                    {
                        Console.Write($"A{i}{roomNumber} ");
                    }
                }
                Console.WriteLine();
            }


            //work from class
            //for (int i = floorNumbers; i > 0; i--)
            //{
            //    for (int j = 0; j < roomsPerFloor; j++)
            //    {
            //        if (i == floorNumbers)
            //        {
            //            Console.Write($"L{i}{j} ");
            //        }
            //        else if (i % 2 == 0)
            //        {
            //            Console.Write($"O{i}{j} ");
            //        }
            //        else
            //        {
            //            Console.Write($"A{i}{j} ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
