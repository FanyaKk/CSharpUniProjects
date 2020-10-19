using System;

namespace _11.FavouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalMovieValue = 0;
            int movieNameLength;
            int movieCount = 0;
            int maxValue = 0;
            string favouriteMovie= "";

            while (command != "STOP")
            {
                string movieName = command;
                for (int i = 0; i < movieName.Length; i++)
                {
                    int movieValue = movieName[i];
                    //char charMovieValue = movieName[i];
                    //int movieValue = charMovieValue;

                    movieNameLength = movieName.Length;
                    if (movieValue >=65 && movieValue <= 90)
                    {
                        movieValue -= movieNameLength;
                    }
                    else if (movieValue >= 97 && movieValue <= 122)
                    {
                        movieValue -= movieNameLength * 2;
                    }
                    totalMovieValue += movieValue;
                }
                if (maxValue < totalMovieValue)
                {
                    favouriteMovie = movieName;
                    maxValue = totalMovieValue;
                }
                movieCount++;
                if (movieCount == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                totalMovieValue = 0;

                command = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {favouriteMovie} with {maxValue} ASCII sum.");
        }
    }
}
