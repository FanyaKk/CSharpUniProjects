using System;

namespace _06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            
            double totalPrice = 0;

            for (int i = 1; i <= clients; i++)
            {
                string product = Console.ReadLine();

                double productPrice = 0;
                int productCounter = 0;
                while (product != "Finish")
                {
                    
                    if (product == "basket")
                    {
                        productCounter++;
                        productPrice += 1.5;
                    }
                    else if (product == "wreath")
                    {
                        productCounter++;
                        productPrice += 3.8;
                    }
                    else if (product == "chocolate bunny")
                    {
                        productCounter++;
                        productPrice += 7;
                    }
                    
                    product = Console.ReadLine();
                }
                if (productCounter % 2 == 0)
                {
                    productPrice *= 0.8;
                }

                totalPrice += productPrice;
                Console.WriteLine($"You purchased {productCounter} items for {productPrice:F2} leva.");
            }
            double averegePrice = totalPrice / clients;
            Console.WriteLine($"Average bill per client is: {averegePrice:F2} leva.");
        }
    }
}
