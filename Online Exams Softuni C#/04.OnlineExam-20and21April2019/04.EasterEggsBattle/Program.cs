using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondplayer = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();

            while(winner != "End of battle" && (eggsFirstPlayer != 0 || eggsSecondplayer != 0))
            {
                if (winner == "one")
                {
                    eggsSecondplayer--;
                }
                else if (winner == "two")
                {
                    eggsFirstPlayer--;
                }
                if (eggsFirstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondplayer} eggs left.");
                    break;
                }
                else if (eggsSecondplayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
                    break;
                }

                winner = Console.ReadLine();
            }
            if (winner == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondplayer} eggs left.");
            }
        }
    }
}
