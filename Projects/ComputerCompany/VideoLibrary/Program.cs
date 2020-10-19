using System;

namespace VideoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = inputN(); // Брой картотеки

            VideoLibrary[] listOfSongs = new VideoLibrary[n]; // Инициализация на масив от картотеки

            fillVideoLibrary(listOfSongs); // Попълва информацията за броя картотеки с песни

            // Сортиране на масива от картотеки според заглавието

            SortByTitle(listOfSongs);

            // Изкарване на данните за всички картотеки

            OutputSongs(listOfSongs);

            Console.ReadLine();
        }

        struct VideoLibrary
        {
            public string title;
            public int styleCode;
            public string performer;
            public int year;
            public string album;
            public int numberOfRuns;
        }

        static int inputN()
        {
            int n;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            } while (!(n >= 1 && n <= 5000));

            return n;
        }

        static void fillVideoLibrary(VideoLibrary[] listOfSongs)
        {
            for (int i = 0; i < listOfSongs.Length; i++)
            {
                Console.WriteLine("Картотека {0}", i + 1);
                Console.Write("Заглавие: ");
                listOfSongs[i].title = Console.ReadLine();
                Console.Write("Код за стил: ");
                listOfSongs[i].styleCode = int.Parse(Console.ReadLine());
                Console.Write("Име на изпълнител: ");
                listOfSongs[i].performer = Console.ReadLine();
                Console.Write("Година: ");
                listOfSongs[i].year = int.Parse(Console.ReadLine());
                Console.Write("Албум: ");
                listOfSongs[i].album = Console.ReadLine();
                Console.Write("Брой пускания: ");
                listOfSongs[i].numberOfRuns = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        static void OutputSongs(VideoLibrary[] listOfSongs)
        {
            for (int i = 0; i < listOfSongs.Length; i++)
            {
                Console.WriteLine("{0}; {1}; {2}; {3}; {4}; {5}", listOfSongs[i].title,
                    listOfSongs[i].styleCode, listOfSongs[i].performer, listOfSongs[i].year,
                    listOfSongs[i].album, listOfSongs[i].numberOfRuns);
            }
        }

        static void SortByTitle(VideoLibrary[] listOfSongs)
        {
            for (int i = 0; i < listOfSongs.Length; i++)
            {
                for (int j = i + 1; j < listOfSongs.Length; j++)
                {
                    VideoLibrary temp = new VideoLibrary();
                    if (String.Compare(listOfSongs[i].title, listOfSongs[j].title, true) == 1)
                    {
                        temp = listOfSongs[i];
                        listOfSongs[i] = listOfSongs[j];
                        listOfSongs[j] = temp;
                    }
                }
            }

        }
    }
}
