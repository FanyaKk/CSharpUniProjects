using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = int.Parse(Console.ReadLine());

            double highestRating = 0;
            double lowestRating = 10;

            string movieWithHighestRating = "";
            string movieWithLowestRating = "";

            double allRatings = 0;

            for (int i = 0; i < numberOfMovies; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                allRatings += rating;

                if (highestRating < rating)
                {
                    highestRating = rating;
                    movieWithHighestRating = movieName;
                }
                else if (lowestRating > rating)
                {
                    lowestRating = rating;
                    movieWithLowestRating = movieName;
                }
            }
            double averageRating = allRatings / numberOfMovies;
            Console.WriteLine($"{movieWithHighestRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{movieWithLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
