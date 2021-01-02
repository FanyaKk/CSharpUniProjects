using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split().ToArray();

                int serialNumber = int.Parse(token[0]);
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                double itemPrice = double.Parse(token[3]);

                double priceForBox = itemQuantity * itemPrice;
                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    ItemQuantity = itemQuantity,
                    PriceForBox = priceForBox
                };
                boxes.Add(box);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(b => b.PriceForBox)
                .ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}{Environment.NewLine}-- {box.ItemName} - ${box.PriceForBox/box.ItemQuantity:f2}: {box.ItemQuantity}{Environment.NewLine}-- ${box.PriceForBox:f2}");
            }
        }
    }
}
