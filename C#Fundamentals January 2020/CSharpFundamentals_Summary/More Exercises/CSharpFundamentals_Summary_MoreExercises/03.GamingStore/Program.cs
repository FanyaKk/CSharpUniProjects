using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            double price;
            double totalSpentMoney = 0.0;
            
            while (command != "Game Time")
            {
                string gameName = command;

                bool isExpensive = false;
                bool isBought = false;

                if (gameName == "OutFall 4")
                {
                    price = 39.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    price = 19.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    if (price > budget)
                    {
                        isExpensive = true;
                    }
                    else
                    {
                        totalSpentMoney += price;
                        budget -= price;
                        isBought = true;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                }

                if (isExpensive)
                {
                    Console.WriteLine("Too Expensive");
                    command = Console.ReadLine();
                }
                else if (isBought)
                {
                    Console.WriteLine($"Bought {gameName}");
                    command = Console.ReadLine();
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (command == "Game Time" && budget != 0)
            {
                 Console.WriteLine($"Total spent: ${totalSpentMoney:F2}. Remaining: ${budget:F2}");
            }
        }
    }
}
