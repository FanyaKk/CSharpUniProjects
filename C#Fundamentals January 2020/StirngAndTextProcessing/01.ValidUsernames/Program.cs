using System;
using System.Linq;
using System.Text;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ").ToArray();
            StringBuilder validUsers = new StringBuilder();

            for (int i = 0; i < username.Length; i++)
            {
                bool isValid = true;
                bool rightLength = false;
                if (username[i].Length >= 3 && username[i].Length <= 16)
                {
                    rightLength = true;
                }
                foreach (char symbol in username[i])
                {
                    if (!(Char.IsLetterOrDigit(symbol) || (symbol == '_') || (symbol == '-')))
                    {
                        isValid = false;
                    }
                }
                if(rightLength && isValid)
                {
                    validUsers.AppendLine(username[i]);
                }
            }
            Console.WriteLine(validUsers);
        }
    }
}
