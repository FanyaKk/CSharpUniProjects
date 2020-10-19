using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rentAHall = int.Parse(Console.ReadLine());

            double statuette = rentAHall * 0.7;
            double catering = statuette * 0.85;
            double soundSystem = catering * 0.5;

            double totalExpense = rentAHall + statuette + catering + soundSystem;
            Console.WriteLine($"{totalExpense:f2}");
        }
    }
}
