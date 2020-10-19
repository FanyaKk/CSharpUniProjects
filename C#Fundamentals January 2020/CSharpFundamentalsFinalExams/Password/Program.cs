using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string password = Console.ReadLine();

                Regex regex = new Regex(@"^([\W\D\S]+)>(?<number>[\d]{3})\|(?<lowerLetter>[a-z]{3})\|(?<upperLetter>[A-Z]{3})\|(?<symbol>[^<>]{3})<\1$");
                Match validPassword = regex.Match(password);

                if (validPassword.Success)
                {
                    string encryptedPassword = validPassword.Groups["number"].Value
                                             + validPassword.Groups["lowerLetter"]
                                             + validPassword.Groups["upperLetter"]
                                             + validPassword.Groups["symbol"];

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
