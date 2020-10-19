using System;

namespace _04Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            int steps = 0;

            while (steps < 10000)
            {
                steps = int.Parse(Console.ReadLine());
                string command = string.Empty;
                if (command == "Going home")
                {

                }
            }



            //int steps = 0;

            //while (steps < 10000)
            //{
            //    string command = Console.ReadLine();

            //    if (command == "Going home")
            //    {
            //        steps += int.Parse(Console.ReadLine());
            //        if (steps >= 10000)
            //        {
            //            Console.WriteLine("Goal reached! Good job!");
            //        }
            //        else
            //        {
            //            int diff = 10000 - steps;
            //            Console.WriteLine($"{diff} more steps to reach goal.");
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        steps += int.Parse(command);
            //        if (steps >= 10000)
            //        {
            //            Console.WriteLine("Goal reached! Good job!");
            //        }
            //    }
            //}
        }
    }
}

//Стъпки

//Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден.
//Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си.Напишете
//програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато
//постигне целта си да се изписва &quot;Goal reached! Good job!&quot;
//Ако иска да се прибере преди това, тя ще въведе командата &quot;Going home&quot; и ще въведе стъпките, които е
//извървяла докато се прибира.След което, ако не е успяла да постигне целта си, на конзолата трябва да се
//изпише: &quot;{разликата между стъпките} more steps to reach goal.&quot;