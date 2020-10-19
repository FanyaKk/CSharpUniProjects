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
                string[] songInformation = Console.ReadLine().Split('_').ToArray();
                string type = songInformation[0];
                string name = songInformation[1];
                string time = songInformation[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSong = songs
                .Where(s => s.TypeList == typeList)
                .ToList();

                foreach (var song in filteredSong)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}
