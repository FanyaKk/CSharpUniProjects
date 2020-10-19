using System;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                int startNameIndex = input.IndexOf('@') + 1;
                int lengthName = input.IndexOf('|') - startNameIndex;
                string name = input.Substring(startNameIndex, lengthName);
                int startAgeIndex = input.IndexOf('#') + 1;
                int lengthAge = input.IndexOf('*') - startAgeIndex;
                string age = input.Substring(startAgeIndex, lengthAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
