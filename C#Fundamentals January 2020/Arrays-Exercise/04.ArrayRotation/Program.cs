using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arrayOfNumbers = Console.ReadLine().Split();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                string currentRotationNumber = arrayOfNumbers[0];// В променливата currentRotationNumber запазваме стойността на позиция [0] от масива arrayOfNumbers, която после добавяме към масива на последната позиция

                for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
                {
                    arrayOfNumbers[j] = arrayOfNumbers[j + 1];//Така заменяме стойността на една позиция(j) със следващата(j+1)
                }
                arrayOfNumbers[arrayOfNumbers.Length - 1] = currentRotationNumber;// Запазваме стойността на currentRotationNumber в последната позиция от масива, като от цялата дължина на масива извадим 1, защото номерацията на позициите започва от 0.
            }
            Console.WriteLine(string.Join(" ", arrayOfNumbers));
            
        }
    }
}
