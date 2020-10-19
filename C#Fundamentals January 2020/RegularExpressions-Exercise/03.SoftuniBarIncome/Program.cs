using System;
using System.Text.RegularExpressions;

namespace _03.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double currIncome = 0;
            double totalIncome = 0;

            string pattern = @"^[%](?<customer>[A-Z][a-z]+)[%][^\|\$\%\.]*?[<](?<product>[\w]+)[>][^\|\$\%\.]*?\|(?<count>[\d]+)\|[^\|\$\%\.]*?(?<price>[\d]+\.?[\d]*)\$$";

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match validInput = Regex.Match(input, pattern);

                if (validInput.Success)
                {
                    string customer = validInput.Groups["customer"].Value;
                    string product = validInput.Groups["product"].Value;
                    int count = int.Parse(validInput.Groups["count"].Value);
                    double price = double.Parse(validInput.Groups["price"].Value);

                    currIncome = price * count;
                    totalIncome += currIncome;
                    Console.WriteLine($"{customer}: {product} - {currIncome:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
