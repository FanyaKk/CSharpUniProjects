using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonsRooms = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bestRoom = 0;
            bool isWin = false;
            int bitcoins = 0;

            for (int i = 1; i <= dungeonsRooms.Length; i++)
            {
                string[] roomContains = dungeonsRooms[i - 1].Split().ToArray();
                string command = roomContains[0];
                int amount = int.Parse(roomContains[1]);

                if(command == "potion")
                {
                    
                    if (health + amount > 100)
                    {
                        int partialAddHelath = 100 - health;
                        health += partialAddHelath;
                        Console.WriteLine($"You healed for {partialAddHelath} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (command == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    string monster = command;
                    health -= amount;
                    if (bestRoom < amount)
                    {
                        bestRoom = i;
                    }
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                }
                if (i == dungeonsRooms.Length)
                {
                    isWin = true;
                }
            }
            if (isWin)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
