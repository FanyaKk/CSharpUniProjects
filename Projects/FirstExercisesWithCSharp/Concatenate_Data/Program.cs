using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);
        }
    }
}
//Съединяване на текст и числа
//Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от
//следния вид: "You are <firstName> <lastName>, a <age>-years old person from <town>."