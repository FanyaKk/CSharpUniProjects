using System;
using System.Text;
using System.Linq;

namespace _04.CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int value = text[i] + 3;
                char newLetter = (char)value;
                encryptedText.Append(newLetter);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
