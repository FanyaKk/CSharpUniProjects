using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());

            if (ages >= 0 && ages < 3)
            {
                Console.WriteLine("baby");
            }
            else if (ages < 14)
            {
                Console.WriteLine("child");
            }
            else if (ages < 20)
            {
                Console.WriteLine("teenager");
            }
            else if (ages < 66)
            {
                Console.WriteLine("adult");
            }
            else if (ages > 65)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
