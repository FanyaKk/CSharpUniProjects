using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime date = new DateTime();

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
