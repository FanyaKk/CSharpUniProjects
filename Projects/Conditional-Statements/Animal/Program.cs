using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalName = Console.ReadLine();

            switch(animalName)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "snake": case "tortoise": case "crocodile": Console.WriteLine("reptile"); break;

                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
//Клас животно
//Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
// dog -> mammal
// crocodile, tortoise, snake -> reptile
// others -> unknown