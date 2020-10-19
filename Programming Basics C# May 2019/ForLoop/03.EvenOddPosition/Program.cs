using System;

namespace _03.EvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int count = 0;
            double number = 0;
            double evenSum = 0;
            double oddSum = 0;

            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 0; i < numbersCount; i++)
            {
                number = double.Parse(Console.ReadLine());
                count++;
                if (count % 2 == 0)
                {
                    evenSum += number;
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (oddMax < number)
                    {
                        oddMax = number;
                    }
                    if (oddMin > number)
                    {
                        oddMin = number;
                    }
                }
            }

            if (evenSum == 0 && oddSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (oddSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else if(evenSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
