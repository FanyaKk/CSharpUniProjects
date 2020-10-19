using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int nameValue = int.MinValue;

            string winnerName = "";

            while (name != "STOP")
            {
                int value = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    value += name[i];
                }
                if (value > nameValue)
                {
                    winnerName = name;
                    nameValue = value;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnerName} - {nameValue}!");
        }
    }
}