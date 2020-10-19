using System;

namespace _07.OperationBetweenNumbers
{
    class OperationBetweenNumbers
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operators = Console.ReadLine();

            double result = 0.0;


            if (operators == "+" || operators == "-" || operators == "*")
            {
                if (operators == "+")
                {
                    result = N1 + N2;
                }
                else if (operators == "-")
                {
                    result = N1 - N2;
                }
                else if (operators == "*")
                {
                    result = N1 * N2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operators} {N2} = {result} - odd");
                }
            }
            else if (operators == "/")
            {
                result = N1 / N2;

                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
            }
            else if (operators == "%")
            {
                result = N1 % N2;

                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
            }
        }
    }
}
//Операции между числа
//Напишете програма, която чете две цели числа(N1 и N2) и оператор, с който да се извърши дадена
//математическа операция с тях.Възможните операции са: Събиране(+), Изваждане(-), Умножение(*),
//Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се
//отпечатат резултата и дали той е четен или нечетен.При обикновеното деление – резултата.При
//модулното деление – остатъка.Трябва да се има предвид, че делителят може да е равен на 0(нула), а на
//нула не се дели. В този случай трябва да се отпечата специално съобщениe.
//Вход
//От конзолата се прочитат 3 реда, въведени от потребителя:
// N1 – цяло число в интервала [0...40 000]
// N2 – цяло число в интервала [0...40 000]
// Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“
//Изход
//Да се отпечата на конзолата един ред:
// Ако операцията е събиране, изваждане или умножение:
//o "{N1} {оператор} {N2} = {резултат} – {even/odd}"
// Ако операцията е деление:
//o "{N1} / {N2} = {резултат}" – резултатът е форматиран до вторият знак след дес. запетая
// Ако операцията е модулно деление:
//o "{N1} % {N2} = {остатък}"
// В случай на деление с 0 (нула):
//o "Cannot divide { N1 } by zero"
