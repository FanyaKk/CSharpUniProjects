using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cakesPerDay = int.Parse(Console.ReadLine());
            int wafersPerDay = int.Parse(Console.ReadLine());
            int pancakesPerDay = int.Parse(Console.ReadLine());

            double cakesSum = cakesPerDay * 45;
            double wafersSum = wafersPerDay * 5.8;
            double pancakesSum = pancakesPerDay * 3.2;

            double totalMoney = ((cakesSum + wafersSum + pancakesSum) * confectionersCount);
            double amountForCharity = (((totalMoney * days)/8)*7);

            Console.WriteLine("{0:f2}", amountForCharity);
        }
    }
}
//Благотворителна кампания
//В сладкарница се провежда благотворителна кампания за събиране на средства, в която могат да се включат
//сладкари от цялата страна.Първоначално прочитаме от конзолата броя на дните, в които тече кампанията и
//броя на сладкарите, които ще се включат.След това на отделни редове получаваме количеството на
//тортите, гофретите и палачинките, които ще бъдат приготвени от един сладкар за един ден.Трябва да се
//има предвид следния ценоразпис:
// Торта - 45 лв.
// Гофрета - 5.80 лв.
// Палачинка – 3.20 лв.
//1/8 от крайната сума ще бъде използвана за покриване на разходите за продуктите по време на
//кампанията. Да се напише програма, която изчислява сумата, която е събрана в края на кампанията.