using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine().Split("_").ToArray();
                string type = songData[0];
                string name = songData[1];
                string time = songData[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeListPrint = Console.ReadLine();

            if (typeListPrint == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSong = songs
                    .Where(s => s.TypeList == typeListPrint)
                    .ToList();
                foreach (var song in filteredSong)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
