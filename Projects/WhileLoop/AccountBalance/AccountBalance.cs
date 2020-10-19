using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            int installment = int.Parse(Console.ReadLine());

            int counter = 0;
            double balance = 0.0;

            while (counter < installment)
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += amount; // другият запис на този ред е balance = balance + amount;
                Console.WriteLine($"Increase: {amount:f2}"); // показваме с колко ще се увеличи баланса по сметката, тоест каква е сумата която е въведена през конзолата!
                counter++; // увеличава брояча  с 1
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
//Баланс по сметка
//Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой
//вноски.На първия ред ще получите колко вноски трябва да се направят.На всеки следващ ред ще
//получавате сумата, която трябва да внесете в сметката, докато не се достигне броя вноски.При всяка
//получена сума на конзолата трябва да се извежда &quot;Increase: &quot; + сумата и тя да се прибавя в сметката.

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 12 of 12
//Ако получите число по-малко от 0 на конзолата трябва да се изведе &quot; Invalid operation!&quot; и програмата
//да приключи.Когато програмата приключи трябва да се принтира &quot; Total: &quot; + общата сума в сметката
//закръглена до втория знак след десетичната запетая.