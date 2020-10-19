using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (!((number == 0) || (number >= 100) && (number <= 200)))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
//Невалидно число
//Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която чете цяло
//число, въведено от потребителя, и печата &quot; invalid&quot; ако въведеното число не е валидно.