using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>[\d]+.?[\d]+)[!](?<qty>[\d]+)";
            List<string> ListNames = new List<string>();
            decimal spentMoney = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match validInput = Regex.Match(input, pattern);
                
                if (validInput.Success)
                {
                    string name = validInput.Groups["name"].Value;
                    decimal price = decimal.Parse(validInput.Groups["price"].Value);
                    int qty = int.Parse(validInput.Groups["qty"].Value);

                    ListNames.Add(name);
                    spentMoney += price * qty;
                }
            }
            Console.WriteLine($"Bought furniture:");
            foreach (var name in ListNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {spentMoney:f2}");

        }
    }
}
