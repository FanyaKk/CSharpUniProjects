﻿using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string sumMessage = "";
            //bool isLetter = true;

            for (int i = 1; i <= lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int value = input + key;
                char message = (char)value;
                //if (!(Char.IsLetter(message)))
                //{
                //    continue;
                //}
                //if (i == 1)
                //{
                //    message = char.ToUpper(message);
                //}
                sumMessage += message;
            }
            Console.WriteLine(sumMessage);
        }
        
    }
}
