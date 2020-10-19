using System;

namespace _06Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            //Ex. 2
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());

            int cakePieces = cakeWidth * cakeHeight;

            int takenPieces = 0;
            int eatenPieces = 0;
            string command = Console.ReadLine();
            command = command.ToUpper();

            while (command != "STOP")
            {
                takenPieces = int.Parse(command);
                eatenPieces += takenPieces;
                if (cakePieces <= eatenPieces)
                {
                    cakePieces = Math.Abs(cakePieces - eatenPieces);
                    Console.WriteLine($"No more cake left! You need {cakePieces} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                cakePieces = cakePieces - eatenPieces;
                Console.WriteLine($"{cakePieces} pieces are left.");
            }

            //Ex. 1
            //double cakeWidth = double.Parse(Console.ReadLine());
            //double cakeLength = double.Parse(Console.ReadLine());
            //string command = Console.ReadLine();
            //command = command.ToUpper();

            //double cakePieces = (cakeWidth * cakeLength);
            //int eatenPieces = 0;

            //while (command != "STOP")
            //{
            //    eatenPieces = int.Parse(command);

            //    if (cakePieces >= eatenPieces)
            //    {
            //        cakePieces -= eatenPieces;
            //    }
            //    else
            //    {
            //        cakePieces = Math.Abs(cakePieces - eatenPieces);
            //        Console.WriteLine($"No more cake left! You need {cakePieces} pieces more.");
            //        break;
            //    }

            //    command = Console.ReadLine();

            //    if (command == "STOP")
            //    {
            //        Console.WriteLine($"{cakePieces} pieces are left.");
            //        break;
            //    }
            //}
        }
    }
}

//Торта

//Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта.Той обаче не знае колко
//парчета могат да си вземат гостите от нея.Вашата задача е да напишете програма, която изчислява броя на

//парчетата, които гостите са взели, преди тя да свърши. Ще получите размерите на тортата (широчина и
//дължина – цели числа в интервала [1...1000]) и след това на всеки ред, до получаване на командата &quot;STOP&quot;
//или докато не свърши тортата, броят на парчетата, които гостите вземат от нея.
//Бележка: Едно парче торта е с размер 1х1 см.
//Да се отпечата на конзолата един от следните редове:
// &quot;{брой парчета} pieces are left.&quot; - ако стигнете до STOP и не са свършили парчетата торта
// &quot;No more cake left! You need { брой недостигащи парчета }
//pieces more.&quot;