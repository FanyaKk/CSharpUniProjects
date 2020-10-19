using System;

namespace _05.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOftravellers = int.Parse(Console.ReadLine());
            int numberOfStops = int.Parse(Console.ReadLine());

            int getBus = 0;
            int getOffBus = 0;
            double travellersInBus = numberOftravellers;

            for (int i = 1; i <= numberOfStops; i++)
            {
                getOffBus = int.Parse(Console.ReadLine());
                getBus = int.Parse(Console.ReadLine());

                travellersInBus -= getOffBus;
                travellersInBus += getBus;
                if (i % 2 == 0)
                {
                    travellersInBus -= 2;
                }
                else
                {
                    travellersInBus += 2;

                }
            }
            Console.WriteLine($"The final number of passengers is : {travellersInBus}");
        }
    }
}
