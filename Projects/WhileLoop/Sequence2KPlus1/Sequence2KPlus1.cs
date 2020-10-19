using System;

namespace Sequence2KPlus1
{
    class Sequence2KPlus1
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
//Редица числа 2k+1
//Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата:
//1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.