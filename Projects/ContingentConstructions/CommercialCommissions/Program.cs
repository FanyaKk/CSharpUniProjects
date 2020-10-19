using System;

namespace CommercialCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                Console.WriteLine("{0:f2}", comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
//Търговски комисионни
//Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:

//Град      0 ≤ s ≤ 500       500 < s ≤ 1 000        1 000 < s ≤ 10 000      s > 10 000
//Sofia         5%                  7%                      8%                  12%
//Varna         4.5%                7.5%                    10%                 13%
//Plovdiv       5.5%                8%                      12%                 14.5%

//© Software University Foundation.This work is licensed under the CC-BY-NC-SA license.
//Follow us: Page 3 of 22
//Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) ,
//въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната
//таблица.Резултатът да се изведе форматиран до 2 цифри след десетичната точка. При невалиден град или
//обем на продажбите (отрицателно число) да се отпечата &quot; error&quot;.