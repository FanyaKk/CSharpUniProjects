using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            List<string> guestList = new List<string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string guestName = command[0];

                if (command[2] == "going!")
                {
                    if (guestList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(guestName);
                    }
                }
                else if (command[2] == "not")
                {
                    if (guestList.Contains(guestName))
                    {
                        guestList.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
        //static void Main(string[] args)           //version 1.0
        //{
        //    int commandsNumber = int.Parse(Console.ReadLine());

        //    List<string> guestList = new List<string>();

        //    for (int i = 0; i < commandsNumber; i++)
        //    {
        //        string[] command = Console.ReadLine().Split().ToArray();

        //        string name = command[0];

        //        if(command[2] == "not")
        //        {
        //            if (guestList.Contains(name))
        //            {
        //                guestList.Remove(name);
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{name} is not in the list!");
        //            }
        //        }
        //        else
        //        {
        //            if (!guestList.Contains(name))
        //            {
        //                guestList.Add(name);
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{name} is already in the list!");
        //            }
        //        }
        //    }
        //    Console.WriteLine(string.Join("\n", guestList));
        //}
    }
}
//Exercise 3. House Party

//Write a program that keeps track of guests, that are going to a house party.On the first line of input, you are going
//to receive the number of commands you are going to receive. On the next lines you are going to receive one of the
//following messages:

//- "{name} is going!"
//- "{name} is not going!"

//If you receive the first message, you have to add the person if he/she is not in the list and if he/she is in the list print
//on the console: "{name} is already in the list!". If you receive the second message, you have to remove the
//person if he/she is in the list and if not print: "{name} is not in the list!". At the end print all the guests.
//Examples

//Input                   |      Output
//4                       |      John is not in the list!
//Allie is going!         |      Allie
//George is going!        |
//John is not going!      |
//George is not going!    |
//--------------------------------------------------------------                          
//5                       |      Tom is already in the list!
//Tom is going!           |      Tom
//Annie is going!         |      Annie
//Tom is going!           |      Garry
//Garry is going!         |      Jerry
//Jerry is going!         |
