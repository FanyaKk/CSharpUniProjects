using System;
using System.Numerics;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            BigInteger tempPokePower = pokePower;

            while (pokePower >= distance)
            {
                count++;
                pokePower -= distance;
                if (pokePower == tempPokePower / 2 && exaustionFactor != 0)
                {
                    pokePower /= exaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
}
