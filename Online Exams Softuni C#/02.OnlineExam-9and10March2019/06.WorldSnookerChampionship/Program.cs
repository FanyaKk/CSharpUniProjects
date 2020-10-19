using System;

namespace _06.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string championshipStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double ticketsPrice = 0;
            double photoPrice = 0;

            if (championshipStage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    ticketsPrice = ticketCount * 55.5;
                }
                else if (ticketType == "Premium")
                {
                    ticketsPrice = ticketCount * 105.2;
                }
                else if (ticketType == "VIP")
                {
                    ticketsPrice = ticketCount * 118.9;
                }
            }
            else if (championshipStage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    ticketsPrice = ticketCount * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    ticketsPrice = ticketCount * 125.22;
                }
                else if (ticketType == "VIP")
                {
                    ticketsPrice = ticketCount * 300.4;
                }
            }
            else if (championshipStage == "Final")
            {
                if (ticketType == "Standard")
                {
                    ticketsPrice = ticketCount * 110.1;
                }
                else if (ticketType == "Premium")
                {
                    ticketsPrice = ticketCount * 160.66;
                }
                else if (ticketType == "VIP")
                {
                    ticketsPrice = ticketCount * 400;
                }
            }
            if (photo == 'Y' && ticketsPrice <= 4000)
            {
                photoPrice = ticketCount * 40;
            }
            if (ticketsPrice > 4000)
            {
                ticketsPrice *= 0.75;
            }
            else if (ticketsPrice > 2500)
            {
                ticketsPrice *= 0.9;
            }

            double finalPrice = ticketsPrice + photoPrice;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
