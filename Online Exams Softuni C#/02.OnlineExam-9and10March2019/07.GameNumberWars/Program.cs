using System;

namespace _07.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            int firstPlayerCard = 0;
            int secondPlayerCard = 0;
            double scoreFirstP = 0;
            double scoreSecondP = 0;

            bool numberWars = false;

            string command = Console.ReadLine();

            while (command != "End of game")
            {
                firstPlayerCard = int.Parse(command);
                secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayerCard = int.Parse(Console.ReadLine());
                    secondPlayerCard = int.Parse(Console.ReadLine());
                    numberWars = true;
                }
                if (firstPlayerCard > secondPlayerCard)
                {
                    if (numberWars == true)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{firstPlayer} is winner with {scoreFirstP} points");
                        break;
                    }
                    scoreFirstP += (firstPlayerCard - secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    if (numberWars == true)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{secondPlayer} is winner with {scoreSecondP} points");
                        break;
                    }
                    scoreSecondP += (secondPlayerCard - firstPlayerCard);
                }
                command = Console.ReadLine();
            }
            if (command == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {scoreFirstP} points");
                Console.WriteLine($"{secondPlayer} has {scoreSecondP} points");
            }
        }
    }
}
