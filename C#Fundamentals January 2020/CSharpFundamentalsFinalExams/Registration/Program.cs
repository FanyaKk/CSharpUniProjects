using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(@"U[$](?<username>[A-Z][a-z]{2,})U[$]P@\$(?<password>[A-Za-z]{5,}[0-9]+)P@\$");

                Match validRegistration = regex.Match(input);

                if (validRegistration.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {validRegistration.Groups["username"]}, " +
                        $"Password: {validRegistration.Groups["password"]}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
