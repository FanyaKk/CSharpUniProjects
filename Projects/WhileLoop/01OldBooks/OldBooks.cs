using System;

namespace _01OldBooks
{
    class OldBooks
    {
        static void Main(string[] args)
        {
            //ex. 1:
            //string favoriteBook = Console.ReadLine();
            //int libraryCapacity = int.Parse(Console.ReadLine());

            //int counterBooks = 0;

            //while (counterBooks < libraryCapacity)
            //{
            //    string nextBook = Console.ReadLine();

            //    if (nextBook == favoriteBook)
            //    {
            //        Console.WriteLine($"You checked {counterBooks} books and found it.");
            //    }
            //    else
            //    {
            //        counterBooks++;
            //    }
            //    if (counterBooks == libraryCapacity)
            //    {
            //        Console.WriteLine("The book you search is not here!");
            //        Console.WriteLine($"You checked {counterBooks} books.");
            //        break;
            //    }
            //}

            //ex. 2:
            //string favoriteBook = Console.ReadLine();
            //int libraryCapacity = int.Parse(Console.ReadLine());

            //int counterBooks = 0;

            //while (counterBooks < libraryCapacity)
            //{
            //    string nextBook = Console.ReadLine();
                
            //    if (nextBook == favoriteBook)
            //    {
            //        Console.WriteLine($"You checked {counterBooks} books and found it.");
            //        break;
            //    }
            //    else 
            //    {
            //        counterBooks++;
            //    }
            //}
            //if (counterBooks == libraryCapacity)
            //{
            //    Console.WriteLine("The book you search is not here!");
            //    Console.WriteLine($"You checked {counterBooks} books.");
            //}



            //ex. 3:
            //string favoriteBook = Console.ReadLine();
            //int libraryCapacity = int.Parse(Console.ReadLine());

            //int counterBooks = 0;

            //while (libraryCapacity > 0)
            //{
            //    string nextBook = Console.ReadLine();
            //    libraryCapacity--;
            //    if (nextBook == favoriteBook)
            //    {
            //        Console.WriteLine($"You checked {counterBooks} books and found it.");
            //        break;
            //    }
            //    else 
            //    {
            //        counterBooks++;
            //    }
            //    if (libraryCapacity == 0)
            //    {
            //        Console.WriteLine($"The book you search is not here!");
            //        Console.WriteLine($"You checked {counterBooks} books.");
            //        break;
            //    }
            //}

            //ex. 4:
            string favoriteBook = Console.ReadLine();
            int numberOfBooks = int.Parse(Console.ReadLine());

            int count = 0;
            bool bookIsFound = false;
            string nextBookName = Console.ReadLine();

            while (count < numberOfBooks)
            {
                if(nextBookName == favoriteBook)
                {
                    bookIsFound = true;
                    break;
                }
                count++;
                nextBookName = Console.ReadLine();
            }
            if (bookIsFound == false)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            else
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
        }
    }
}
//Старата Библиотека

//Ани отива до родния си град след много дълъг период извън страната.Прибирайки се вкъщи тя вижда
//старата библиотека на баба си и си спомня за любимата си книга. Помогнете на Ани, като напишете програма
//в която тя въвежда търсената от нея книга(текст) и капацитета на библиотеката(цяло число). Докато Ани не
//намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на
//нов ред името на всяка следваща книга (текст).
// Ако не открие книгата да се отпечата на два реда:
//o "The book you search is not here!"
//o "You checked {брой} books."
// Ако открие книгата си се отпечатва един ред:
//o "You checked {брой} books and found it."