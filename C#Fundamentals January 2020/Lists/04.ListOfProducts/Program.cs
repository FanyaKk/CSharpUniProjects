using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)         //version 2.0
        {
            int lineCount = int.Parse(Console.ReadLine());

            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < lineCount; i++)
            {
                string products = Console.ReadLine();

                listOfProducts.Add(products);
            }
            listOfProducts.Sort();
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfProducts[i]}");
            }
        }
        //static void Main(string[] args)       //version 1.0
        //{

        //    int numberOfLines = int.Parse(Console.ReadLine());

        //    List<string> products = new List<string>();

        //    for (int i = 0; i < numberOfLines; i++)
        //    {
        //        string currentProduct = Console.ReadLine();

        //        products.Add(currentProduct);
        //    }
        //    products.Sort();
        //    for (int i = 0; i < products.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}.{products[i]}");
        //    }

        //}
    }
}
//Exercise 4. List of Products
//
//Read a number n and n lines of products.Print a numbered list of all the products ordered by name.
//
//Examples:
//
//Input        |     Output
//4            |     
//Potatoes     |     1.Apples
//Tomatoes     |     2.Onions
//Onions       |     3.Potatoes
//Apples       |     4.Tomatoes