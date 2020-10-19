using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterFrom = char.Parse(Console.ReadLine());
            char letterTo = char.Parse(Console.ReadLine());

            char letterNoPrint = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = letterFrom; i <= letterTo; i++)
            {
                for (char j = letterFrom; j <= letterTo; j++)
                {
                    for (char k = letterFrom; k <= letterTo; k++)
                    {
                        if (i != letterNoPrint && j != letterNoPrint && k != letterNoPrint)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                            //if (i == letterTo && j == letterTo && k == letterTo)
                            //{
                            //    Console.Write(counter);
                            //}
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
