//using System;

//namespace _07.VendingMachine
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string command = Console.ReadLine();

//            double sumCoins = 0.0;
//            bool isValid = true;

//            while (command != "Start")
//            {
//                double insertCoins = double.Parse(command);

//                if (insertCoins == 0.1 || insertCoins == 0.2 || insertCoins == 0.5 || insertCoins == 1 || insertCoins == 2)
//                {
//                    sumCoins += insertCoins;
//                }
//                else
//                {
//                    Console.WriteLine($"Cannot accept {insertCoins}");
//                }

//                command = Console.ReadLine();
//            }
//            if (command == "Start")
//            {
//                command = Console.ReadLine();

//                while (command != "End")
//                {
//                    string product = command;
//                    double productPrice = 0;

//                    if (product == "Nuts")
//                    {
//                        productPrice = 2.0;
//                    }
//                    else if (product == "Water")
//                    {
//                        productPrice = 0.7;
//                    }
//                    else if (product == "Crisps")
//                    {
//                        productPrice = 1.5;
//                    }
//                    else if (product == "Soda")
//                    {
//                        productPrice = 0.8;
//                    }
//                    else if (product == "Coke")
//                    {
//                        productPrice = 1.0;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid product");
//                        isValid = false;
//                    }
//                    if (productPrice > sumCoins)
//                    {
//                        Console.WriteLine("Sorry, not enough money");
//                    }
//                    else if (isValid == true)
//                    {
//                        sumCoins -= productPrice;
//                        Console.WriteLine($"Purchased {product.ToLower()}");
//                    }

//                    command = Console.ReadLine();
//                }
//                if (command == "End")
//                {
//                    Console.WriteLine($"Change: {sumCoins:F2}");
//                }
//            }
//        }
//    }
//}
using System;

namespace _08.VendingMachine
{
    class VendingMachine
    {
        static void Main()
        {

            string input = Console.ReadLine();
            double inputToNum = double.Parse(input);
            double sum = 0;
            double productSum = 0;


            while (input != "Start")
            {
                inputToNum = double.Parse(input);

                if (inputToNum != 0.1 && inputToNum != 0.2 && inputToNum != 0.5 && inputToNum != 1 && inputToNum != 2)
                {
                    Console.WriteLine($"Cannot accept {inputToNum:F2}");
                    //continue;
                }
                else
                {
                    sum += inputToNum;
                }
                
                input = Console.ReadLine();
            }

            if (input == "Start")
            {
                input = Console.ReadLine();

                double Coke = 1.0;
                double Nuts = 2.0;
                double Crisps = 1.5;
                double Soda = 0.8;
                double Water = 0.7;

                productSum = 0;

                while (input != "End")
                {
                    if (input != "Water" && input != "Coke" && input != "Soda" && input != "Crisps" && input != "Nuts")
                    {
                        //if (input == "End")
                        //{
                        //    Console.WriteLine($"Change: {sum - productSum:F2}");
                        //    break;
                        //}
                        Console.WriteLine("Invalid product");

                    }
                    if (productSum > sum)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    if (input == "Coke" && (sum > productSum))
                    {
                        productSum += 1.0;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input}");
                        }

                    }
                    else if (input == "Nuts" && (sum > productSum))
                    {
                        productSum += 2.0;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 2;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input}");
                        }
                    }
                    else if (input == "Crisps" && (sum > productSum))
                    {
                        productSum += 1.5;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input}");
                        }
                    }
                    else if (input == "Soda" && (sum > productSum))
                    {
                        productSum += 0.8;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input}");
                        }
                    }
                    else if (input == "Water" && (sum > productSum))
                    {
                        productSum += 0.7;
                        if (productSum > sum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            productSum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input}");
                        }
                    }
                    input = Console.ReadLine();
                }
                if (input == "End")
                {
                    Console.WriteLine($"Change: {sum - productSum:F2}");
                }
            }
        }
    }
}