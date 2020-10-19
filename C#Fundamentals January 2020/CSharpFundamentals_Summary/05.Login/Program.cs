using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();

                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (password == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
