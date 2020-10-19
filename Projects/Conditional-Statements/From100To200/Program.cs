using System;

namespace From100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
//Число от 100 до 200
//Да се напише програма, която чете цяло число, въведено от потребителя и проверява, дали е под 100, между
//100 и 200 или над 200. Да се отпечатат съответно съобщения, като в примерите по-долу:
//Примерен вход и изход
//вход        изход        вход          изход           вход        изход
// 95     Less than 100    120    Between 100 and 200    210    Greater than 200