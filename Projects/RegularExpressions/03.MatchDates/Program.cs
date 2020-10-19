using System;
//using System.Linq;
//using System.Text;
//using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            string pattern = @"\b(?<day>[\d]{2})([\/]|[-]|[.])(?<month>[A-Z][a-z]{2})\1(?<year>[\d]{4})\b";

            Regex regex = new Regex(pattern);
            MatchCollection validDates = Regex.Matches(dates, pattern);

            foreach (Match date in validDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
