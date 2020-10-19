using System;

namespace _05.PrintPartPfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = start; i <= end; i++)
            {
                char symbol = (char)i;
                text += symbol + " ";
            }
            Console.WriteLine(text);
        }
    }
}
