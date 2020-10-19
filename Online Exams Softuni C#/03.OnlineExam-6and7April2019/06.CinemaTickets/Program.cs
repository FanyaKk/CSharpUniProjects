using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;
            double ticketCount = 0;

            double usedPlaces = 0;


            while (movieName != "Finish")
            {
                double freePlaces = double.Parse(Console.ReadLine());
                for (int i = 1; i <= freePlaces; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    if (ticketType == "student")
                    {
                        studentCount++;
                        ticketCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCount++;
                        ticketCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCount++;
                        ticketCount++;
                    }
                    usedPlaces = i / freePlaces * 100;
                }
                Console.WriteLine($"{movieName} - {usedPlaces:f2}% full.");
                movieName = Console.ReadLine();
            }
            double usedStudentPlaces = studentCount / ticketCount * 100;
            double usedStandardPlaces = standardCount / ticketCount * 100;
            double usedKidPlaces = kidCount / ticketCount * 100;

            Console.WriteLine($"Total tickets: {ticketCount}");
            Console.WriteLine($"{usedStudentPlaces:f2}% student tickets.");
            Console.WriteLine($"{usedStandardPlaces:f2}% standard tickets.");
            Console.WriteLine($"{usedKidPlaces:f2}% kids tickets.");
        }
    }
}
e