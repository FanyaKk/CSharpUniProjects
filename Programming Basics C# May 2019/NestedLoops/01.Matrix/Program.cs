using System;

namespace _01.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int firstNumFirstRow = a; firstNumFirstRow <= b; firstNumFirstRow++)
            {
                for (int secondNumFirstRow = a; secondNumFirstRow <= b; secondNumFirstRow++)
                {
                    for (int firstNumSecondRow = c; firstNumSecondRow <= d; firstNumSecondRow++)
                    {
                        for (int secondNumSecondNum = c; secondNumSecondNum <= d; secondNumSecondNum++)
                        {
                            if(((firstNumFirstRow + secondNumSecondNum) == (secondNumFirstRow + firstNumSecondRow)) && (firstNumFirstRow != secondNumFirstRow) && (secondNumSecondNum != firstNumSecondRow))
                            {
                                Console.WriteLine($"{firstNumFirstRow}{secondNumFirstRow}");
                                Console.WriteLine($"{firstNumSecondRow}{secondNumSecondNum}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
