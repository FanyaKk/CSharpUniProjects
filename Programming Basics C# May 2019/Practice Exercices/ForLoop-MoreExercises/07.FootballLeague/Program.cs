using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double fensCount = double.Parse(Console.ReadLine());

            int fensA = 0;
            int fensB = 0;
            int fensV = 0;
            int fensG = 0;

            double fensAP = 0;
            double fensBP = 0;
            double fensVP = 0;
            double fensGP = 0;

            for (int i = 0; i < fensCount; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fensA++;
                }
                else if (sector == "B")
                {
                    fensB++;
                }
                else if (sector == "V")
                {
                    fensV++;
                }
                else if (sector == "G")
                {
                    fensG++;
                }
            }
            fensAP = fensA / fensCount * 100;
            fensBP = fensB / fensCount * 100;
            fensVP = fensV / fensCount * 100;
            fensGP = fensG / fensCount * 100;

            double totalFensInPercent = fensCount / stadiumCapacity * 100;

            Console.WriteLine($"{fensAP:f2}%");
            Console.WriteLine($"{fensBP:f2}%");
            Console.WriteLine($"{fensVP:f2}%");
            Console.WriteLine($"{fensGP:f2}%");
            Console.WriteLine($"{totalFensInPercent:f2}%");
        }
    }
}
