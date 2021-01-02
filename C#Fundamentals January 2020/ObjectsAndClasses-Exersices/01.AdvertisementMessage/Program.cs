using System;
using System.Linq;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string advertisementMessage = string.Empty;

            Random rndPosition = new Random();
            //Random rndPhrases = new Random();
            //Random rndEvents = new Random();
            //Random rndAuthors = new Random();
            //Random rndCities = new Random();

            int numberOfAdvertisements = int.Parse(Console.ReadLine());

            string[] phrases = ("Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can’t live without this product.").Split(", ").ToArray();
            string[] events = ("Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!").Split(", ").ToArray();
            string[] authors = ("Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva").Split(", ").ToArray();
            string[] cities = ("Burgas, Sofia, Plovdiv, Varna, Ruse").Split(", ").ToArray();

            for (int i = 0; i < numberOfAdvertisements; i++)
            {
                int phrasesPosition = rndPosition.Next(phrases.Length);
                //string phrasesWord = phrases[phrasesPosition];
                //advertisementMessage = phrasesWord;
                int eventsPosition = rndPosition.Next(events.Length);
                //string eventsWord = events[eventsPosition];
                //advertisementMessage += " " + eventsWord;
                int authorsPosition = rndPosition.Next(authors.Length);
                //string authorsWord = authors[authorsPosition];
                //advertisementMessage += " " + authorsWord;
                int citiesPosition = rndPosition.Next(cities.Length);
                //string citiesWord = cities[citiesPosition];
                //advertisementMessage += " - " + citiesWord;

                Console.WriteLine($"{phrases[phrasesPosition]} {events[eventsPosition]} {authors[authorsPosition]} - {cities[citiesPosition]}");
            }
        }
    }
}
