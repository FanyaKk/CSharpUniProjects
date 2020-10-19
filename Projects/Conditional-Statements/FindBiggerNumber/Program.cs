using System;

namespace FindBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
//Намиране на по-голямото число
//Да се напише програма, която чете две цели числа въведени от потребителя и отпечатва по-голямото от
//двете.