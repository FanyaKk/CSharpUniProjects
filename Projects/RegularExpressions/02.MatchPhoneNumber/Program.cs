using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

            string pattern = @"[+359]{4}([-]|[ ])[2]\1[\d]{3}\1[\d]{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchNumbers = regex.Matches(phoneNumber);
            List<string> phoneList = new List<string>();

            foreach (Match phones in matchNumbers)
            {
                phoneList.Add(phones.Value);
            }
            Console.WriteLine(string.Join(", ", phoneList));
        }
    }
}
