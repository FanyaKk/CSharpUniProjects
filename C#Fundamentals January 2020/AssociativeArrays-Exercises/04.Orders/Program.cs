using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nameAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> nameAndQty = new Dictionary<string, int>();

            string command = "";

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] productInfo = command.Split().ToArray();

                string productName = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int qty = int.Parse(productInfo[2]);

                if (!nameAndPrice.ContainsKey(productName))
                {
                    nameAndPrice[productName] = 0;
                    nameAndQty[productName] = 0;
                }
                nameAndQty[productName] += qty;
                nameAndPrice[productName] = price * nameAndQty[productName];   
            }
            foreach (var product in nameAndPrice)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
