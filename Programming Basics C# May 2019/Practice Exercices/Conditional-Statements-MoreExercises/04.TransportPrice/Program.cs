using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayType = Console.ReadLine();

            double taxiDayPrice = 0.70 + (kilometers * 0.79);
            double taxiNightPrice = 0.70 + (kilometers * 0.90);

            double busPrice = kilometers * 0.09;
            double trainPrice = kilometers * 0.06;

            if (dayType == "day")
            {
                if (kilometers >= 20)
                {
                    if (kilometers >= 100)
                    {
                        if (taxiDayPrice < busPrice)
                        {
                            Console.WriteLine($"{taxiDayPrice:f2}");
                        }
                        else if (busPrice < taxiDayPrice)
                        {
                            Console.WriteLine($"{busPrice:f2}");
                        }
                        else if (taxiDayPrice < trainPrice)
                        {
                            Console.WriteLine($"{taxiDayPrice:f2}");
                        }
                        else if (trainPrice < taxiDayPrice)
                        {
                            Console.WriteLine($"{trainPrice:f2}");
                        }
                        else if (busPrice < trainPrice)
                        {
                            Console.WriteLine($"{busPrice:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{trainPrice:f2}");
                        }
                    }
                    else if (taxiDayPrice < busPrice)
                    {
                        Console.WriteLine($"{taxiDayPrice:f2}");
                    }
                    else if (busPrice < taxiDayPrice)
                    {
                        Console.WriteLine($"{busPrice:f2}");
                    }
                }
                if (kilometers < 20)
                {
                    Console.WriteLine($"{taxiDayPrice:f2}");
                }
            }
            else if (dayType == "night")
            {
                if (kilometers >= 20)
                {
                    if (kilometers >= 100)
                    {
                        if (taxiNightPrice < busPrice)
                        {
                            Console.WriteLine($"{taxiNightPrice:f2}");
                        }
                        else if (busPrice < taxiNightPrice)
                        {
                            Console.WriteLine($"{busPrice:f2}");
                        }
                        else if (taxiNightPrice < trainPrice)
                        {
                            Console.WriteLine($"{taxiNightPrice:f2}");
                        }
                        else if (trainPrice < taxiNightPrice)
                        {
                            Console.WriteLine($"{trainPrice:f2}");
                        }
                        else if (busPrice < trainPrice)
                        {
                            Console.WriteLine($"{busPrice:f2}");
                        }
                        else
                        {
                            Console.WriteLine($"{trainPrice:f2}");
                        }
                    }
                    else if (taxiNightPrice < busPrice)
                    {
                        Console.WriteLine($"{taxiNightPrice:f2}");
                    }
                    else if (busPrice < taxiNightPrice)
                    {
                        Console.WriteLine($"{busPrice:f2}");
                    }
                }
                if (kilometers < 20)
                {
                    Console.WriteLine($"{taxiNightPrice:f2}");
                }
            }
        }
    }
}