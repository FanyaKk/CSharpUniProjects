using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //v1
            string inputDate = Console.ReadLine();

            DateTime date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

            //v2
            //DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            //Console.WriteLine(inputDate.DayOfWeek);

            //DateTime date = DateTime.Now;

            //Console.WriteLine(date);
        }
    }
}
