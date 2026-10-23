using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollectionManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Movie Collection Manager!");

            MovieCollection movieCollection = new MovieCollection();

            movieCollection.AddMovie(new Movie("Inception", "Christopher Nolan", 2010, "Sci-Fi", 8.8));
            movieCollection.AddMovie(new Movie("The Dark Knight", "Christopher Nolan", 2008, "Action", 9.0));
            movieCollection.AddMovie(new Movie("Interstellar", "Christopher Nolan", 2014, "Sci-Fi", 8.6));
            movieCollection.AddMovie(new Movie("The Godfather", "Francis Ford Coppola", 1972, "Crime", 9.2));

            movieCollection.RemoveMovie("The Godfather");

            Console.Write("Search movie collection by title: ");
            string movieTitle = Console.ReadLine();
            Movie? foundMovie = movieCollection.FindMovieByTitle(movieTitle);

            if (foundMovie != null)
            {
                Console.WriteLine(foundMovie);
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }

        }
    }
}
