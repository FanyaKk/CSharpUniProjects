using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> priceAndName = new Dictionary<string, double>();
            Dictionary<string, int> qtyAndName = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] command = input.Split().ToArray();

                string productName = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!priceAndName.ContainsKey(productName))
                {
                    priceAndName[productName] = 0;
                    qtyAndName[productName] = 0;
                }
                qtyAndName[productName] += quantity;
                priceAndName[productName] = price * qtyAndName[productName];

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, priceAndName.Select(p => $"{p.Key} -> {p.Value:f2}")));
        }
        //static void Main(string[] args)               //version 1.0
        //{
        //    Dictionary<string, double> nameAndPrice = new Dictionary<string, double>();
        //    Dictionary<string, int> nameAndQty = new Dictionary<string, int>();

        //    string command = "";

        //    while ((command = Console.ReadLine()) != "buy")
        //    {
        //        string[] productInfo = command.Split().ToArray();

        //        string productName = productInfo[0];
        //        double price = double.Parse(productInfo[1]);
        //        int qty = int.Parse(productInfo[2]);

        //        if (!nameAndPrice.ContainsKey(productName))
        //        {
        //            nameAndPrice[productName] = 0;
        //            nameAndQty[productName] = 0;
        //        }
        //        nameAndQty[productName] += qty;
        //        nameAndPrice[productName] = price * nameAndQty[productName];   
        //    }
        //    foreach (var product in nameAndPrice)
        //    {
        //        Console.WriteLine($"{product.Key} -> {product.Value:f2}");
        //    }
        //}
    }
}
//4. Orders

//Write a program that keeps information about products and their prices.Each product has a name, a price and a
//quantity.If the product doesn’t exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different,
//replace the price as well.

//You will receive products’ names, prices and quantities on new lines.Until you receive the command "buy", keep
//adding items.When you do receive the command "buy", print the items with their names and total price of all the
//products with that name.

//Input
// Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
// The product data is always delimited by a single space.
//Output
// Print information about each product in the following format:
//"{productName} -> {totalPrice}"
// Format the average grade to the 2 nd digit after the decimal separator.
//Examples

//Input                         Output

//Beer 2.20 100                 Beer -> 220.00
//IceTea 1.50 50                IceTea -> 75.00
//NukaCola 3.30 80              NukaCola -> 264.00
//Water 1.00 500                Water -> 500.00
//buy

//Beer 2.40 350                 Beer -> 660.00
//Water 1.25 200                Water -> 250.00
//IceTea 5.20 100               IceTea -> 110.00
//Beer 1.20 200
//IceTea 0.50 120
//buy

//CesarSalad 10.20 25           CesarSalad -> 255.00
//SuperEnergy 0.80 400          SuperEnergy -> 320.00
//Beer 1.35 350                 Beer -> 472.50
//IceCream 1.50 25              IceCream -> 37.50
//buy