using System;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Console.WriteLine("{0:f2}", bgn);
        }
    }
}
//Напишете програма за конвертиране на щатски долари(USD) в български лева(BGN). Закръглете резултата
//до 2 цифри след десетичната запетая.Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.