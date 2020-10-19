using System;

namespace TheSameNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
           
            if (number1 != number2)
            {
                Console.WriteLine("no");
            }
            else if (number1 != number3)
            {
                Console.WriteLine("no");
            }
            else if (number2 != number3)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
//Еднакви 3 числа
//Да се въведат 3 числа и да се отпечата дали са еднакви(yes / no)