using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Library Lib = new Library();
        int num = int.Parse(Console.ReadLine());
        fillLibrary(Lib, num);

        foreach (var a in Lib.final.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0} -> {1:f2}", a.Key, a.Value);
        }
    }

    private static void fillLibrary(Library Lib, int num)
    {
        for (int i = 0; i < num; i++)
        {
            string[] a = Console.ReadLine().Split();
            Book myBook = new Book() { Title = a[0], Author = a[1], Publisher = a[2], ReleaseDate = a[3], ISBN = a[4], Price = decimal.Parse(a[5]) };

            if (!Lib.final.ContainsKey(myBook.Author))
            {
                Lib.final.Add(myBook.Author, myBook.Price);
            }
            else
            {
                Lib.final[myBook.Author] += myBook.Price;
            }
        }
    }


}

public class Library
{
    public string Name { get; set; }
    public Dictionary<string, decimal> final = new Dictionary<string, decimal>();
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public decimal Price { get; set; }
}