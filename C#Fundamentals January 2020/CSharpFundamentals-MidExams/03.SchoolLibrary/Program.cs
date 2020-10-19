using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] input = command.Split(" | ").ToArray();
                command = input[0];

                if (command == "Add Book")
                {
                    string bookName = input[1];
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (command == "Take Book")
                {
                    string bookName = input[1];
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                }
                else if (command == "Swap Books")
                {
                    string firstBook = input[1];
                    string secondBook = input[2];
                    if (books.Contains(firstBook) && books.Contains(secondBook))
                    {
                        int firstIndex = books.IndexOf(firstBook);
                        int secondIndex = books.IndexOf(secondBook);
                        books[firstIndex] = secondBook;
                        books[secondIndex] = firstBook;
                    }
                }
                else if (command == "Insert Book")
                {
                    string bookName = input[1];
                    if (!books.Contains(bookName))
                    {
                        books.Add(bookName);
                    }
                }
                else if (command == "Check Book")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 && index < books.Count)
                    {
                        string bookName = books[index];
                        Console.WriteLine(bookName);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
