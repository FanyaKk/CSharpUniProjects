using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsOnlyWithDigitsAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsConsistTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(IsValidLength(password) && IsOnlyWithDigitsAndLetters(password) && IsConsistTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool IsValidLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;  
        }
        static bool IsOnlyWithDigitsAndLetters (string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsConsistTwoDigits(string password)
        {
            int digitCount = 0;
            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
            }
            return digitCount >= 2;
            //if (digitCount !>= 2)
            //{
            //    return false;
            //}
            //return true;
        }
    }
}
