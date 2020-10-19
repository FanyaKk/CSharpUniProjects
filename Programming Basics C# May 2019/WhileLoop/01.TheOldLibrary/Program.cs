using System;

namespace _01.TheOldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            double libraryCapacity = double.Parse(Console.ReadLine());

            int count = 0;

            while (libraryCapacity > count)
            {
                string book = Console.ReadLine();

                if (book == searchBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                }
                else
                {
                    count++;
                }
                if (libraryCapacity == count)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    break;
                }
            }
        }
    }
}
