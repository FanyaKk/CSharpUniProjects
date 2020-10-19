using System;

namespace VideoLibrary
{
    class Program
    {
        public class VideoLibrary
        {
            public VideoLibrary(string title, string stile, string singer, DateTime releaseDate, string album, int number)
            {
                Title = title;
                Stile = stile;
                Singer = singer;
                ReleaseDate = releaseDate;
                Album = album;
                Number = number;
            }

            public string Title { get; set; }

            public string Stile { get; set; }

            public string Singer { get; set; }

            public DateTime ReleaseDate { get; set; }

            public string Album { get; set; }

            public int Number { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
